using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantPOS
{
    public partial class OrderScreen : UserControl
    {
        private int employeeID;
        private int orderNum;
        private int tableNum;
        public OrderScreen(int orderNum, int tableNum, int employeeID)
        {
            InitializeComponent();
            this.Load += OrderScreen_Load;
            this.employeeID = employeeID;
            this.orderNum = orderNum;
            this.tableNum = tableNum;
        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {
            DatabaseHandler.updateOrderTotal(orderNum);
            LoadCategoryButtons(DatabaseHandler.GetCategoryNames());
            tableLabel.Text = "Table: " + tableNum + "    Order: " + orderNum;
            loadOrderedItems(orderNum);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewChanger.ChangeView(new LoginScreen()); // Go back to login screen when the button is clicked
        }

        private void LoadCategoryButtons(List<string> categories) // Loads categories from database
        {
            menuCategoryPanel.Controls.Clear();

            foreach (string category in categories)
            {
                Button button = new Button
                {
                    Text = category,
                    Tag = category,
                    Width = 240,
                    Height = 120,
                    Margin = new Padding(20),
                    Font = new Font("Arial", 12, FontStyle.Bold)
                };

                button.Click += CategoryButton_Click;

                menuCategoryPanel.Controls.Add(button);

            }

        }

        private void CategoryButton_Click(object sender, EventArgs e) // Displays selected category's items in menu items panel.
        {
            Button clickedButton = (Button)sender;
            string categorySelected = (string)clickedButton.Tag;
            LoadMenuItems(DatabaseHandler.GetMenuItems(categorySelected));
        }

        private void LoadMenuItems(List<string> menuItems)
        {
            menuItemsPanel.Controls.Clear();

            Form1 mainForm = (Form1)Application.OpenForms["Form1"]; // Used to access imageList from in main form.
            ImageList drinkImages = mainForm.imageList1;

            foreach (string item in menuItems)
            {
                if (drinkImages.Images.ContainsKey(item)) // Add button with image if the image exists in the imagelist.
                {
                    Button button = new Button
                    {
                        // Text = item,
                        Tag = item,
                        Width = 200,
                        Height = 100,
                        Margin = new Padding(20),
                        BackgroundImage = drinkImages.Images[item],
                        BackgroundImageLayout = ImageLayout.Zoom
                    };

                    button.Click += MenuItemButton_Click;

                    menuItemsPanel.Controls.Add(button);
                }
                else // If no image exists then use the text to show name.
                {
                    Button button = new Button
                    {
                        Text = item,
                        Tag = item,
                        Width = 200,
                        Height = 100,
                        Margin = new Padding(20),
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        BackColor = Color.Lavender
                    };

                    button.Click += MenuItemButton_Click;

                    menuItemsPanel.Controls.Add(button);
                }
            }
        }

        private void MenuItemButton_Click(object sender, EventArgs e) // Add item to order and display in the listbox when clicked
        {
            Button clickedButton = (Button)sender;
            string itemToAdd = (string)clickedButton.Tag;
            DatabaseHandler.AddItemToOrder(tableNum, itemToAdd, orderNum);
            DatabaseHandler.updateOrderTotal(orderNum);
            loadOrderedItems(orderNum);
        }

        private void viewTablesButton_Click(object sender, EventArgs e)
        {
            ViewChanger.ChangeView(new TableView(employeeID));
        }


        private void loadOrderedItems(int orderNum) // Load ordered items into listbox and subtotal, tax, and total
        {
            orderedItemsListbox.Items.Clear();
            foreach (orderItem item in DatabaseHandler.GetOrderedItems(orderNum))
            {
                orderedItemsListbox.Items.Add(item);
                if (!string.IsNullOrWhiteSpace(item.modifications))
                {
                    orderedItemsListbox.Items.Add("\t* " + item.modifications);
                }
            }

            decimal subtotal = DatabaseHandler.GetOrderTotal(orderNum);
            subtotalLabel.Text = "Subtotal: $" + subtotal.ToString("0.00");

            decimal tax = subtotal * 0.1m; // Tax rate of 10%
            taxLabel.Text = "Tax: $" + tax.ToString("0.00");

            decimal total = subtotal + tax;
            totalLabel.Text = "Total: $" + total.ToString("0.00");
        }

        private void removeItem(int orderedItemID) 
        {
            DatabaseHandler.RemoveItemFromOrder(orderedItemID);
            DatabaseHandler.updateOrderTotal(orderNum);
            loadOrderedItems(orderNum);
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            if (orderedItemsListbox.SelectedItem is not orderItem)
            {
                return; // Do nothing if selected item is modification and not the item itself
            }

            if (orderedItemsListbox.SelectedIndex == -1) // Stop program from crashing when delete button is pressed but no item is selected.
            {
                return;
            }

            if (DatabaseHandler.GetEmployeeType(employeeID) == "Manager") // Only allows managers to delete items.
            { 

            orderItem selectedItem = (orderItem)orderedItemsListbox.SelectedItem;
            int itemToRemove = selectedItem.orderItemID;
            removeItem(itemToRemove);
            }
            else
            {
                var popup = new managerApprovalPopup();
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    if (DatabaseHandler.GetEmployeeType(popup.employeeID) == "Manager")
                    {
                        orderItem selectedItem = (orderItem)orderedItemsListbox.SelectedItem;
                        int itemToRemove = selectedItem.orderItemID;
                        removeItem(itemToRemove);
                    }
                }
                return;
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (orderedItemsListbox.SelectedItem is not orderItem)
            {
                return; // Do nothing if selected item is modification and not the item itself
            }

            string modification = modificationsTextBox.Text;
            if (string.IsNullOrEmpty(modification) || (orderedItemsListbox.SelectedIndex == -1))
            {
                return; // Do nothing if no modification is input or no item selected when button is pressed
            }
            orderItem selectedItem = (orderItem)orderedItemsListbox.SelectedItem;
            int itemToModify = selectedItem.orderItemID;
            DatabaseHandler.AddModification(itemToModify, modification);
            loadOrderedItems(orderNum);
            modificationsTextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e) // Closes check and goes back to table view.
        {
            DatabaseHandler.CloseCheck(orderNum);
            ViewChanger.ChangeView(new TableView(employeeID));
        }
    }
}
