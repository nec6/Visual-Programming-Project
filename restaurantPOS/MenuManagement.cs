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
    public partial class MenuManagement : UserControl
    {
        private int employeeID;
        public MenuManagement(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
        }

        // ── Add button (button2) ──
        private void button2_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string price = tbPrice.Text.Trim();
            string category = tbCat.Text.Trim();
            string modifiers = tbMods.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Name and Price are required.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(price, out decimal parsedPrice))
            {
                MessageBox.Show("Price must be a valid number.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatabaseHandler.addMenuItem(name, category, Convert.ToDecimal(parsedPrice), false);
            MenuManagement_Load(null, null); // Refresh the ListView

            tbName.Clear();
            tbPrice.Clear();
            tbCat.Clear();
            tbMods.Clear();
            tbName.Focus();
        }

        // ── Delete button (btnDel) ──
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedItems.Count == 0) // Do nothing if no item is selected
            {
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete the selected item?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                ListViewItem item = lstEmployees.SelectedItems[0];
                int itemToRemove = Convert.ToInt32(item.SubItems[3].Text);

                DatabaseHandler.removeMenuItem(itemToRemove);
                MenuManagement_Load(null, null); // Refresh the ListView
            }
        }


        // ── Form Load: set up ListView columns ──
        private void MenuManagement_Load(object sender, EventArgs e)
        {
            lstEmployees.View = View.Details;
            lstEmployees.FullRowSelect = true;
            lstEmployees.GridLines = true;
            lstEmployees.MultiSelect = false;

            lstEmployees.Columns.Add("Items", 150);
            lstEmployees.Columns.Add("Price", 100);
            lstEmployees.Columns.Add("Category", 120);
            lstEmployees.Columns.Add("Item ID", 180);

            lstEmployees.Items.Clear();
            foreach (orderItem item in DatabaseHandler.GetAllMenuItems())
            {
                ListViewItem listItem = new ListViewItem(item.itemName);
                listItem.SubItems.Add(item.price.ToString());
                listItem.SubItems.Add(item.category);
                listItem.SubItems.Add(item.orderItemID.ToString());
                lstEmployees.Items.Add(listItem);
            }
        }

        // ── ListView selection: populate form fields ──
        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedItems.Count > 0)
            {
                ListViewItem selected = lstEmployees.SelectedItems[0];
                tbName.Text = selected.SubItems[0].Text;
                tbPrice.Text = selected.SubItems[1].Text;
                tbCat.Text = selected.SubItems[2].Text;
                tbMods.Text = selected.SubItems[3].Text;
            }
        }

        // ── TextChanged event stubs (required by Designer) ──
        private void tbName_TextChanged(object sender, EventArgs e) { }
        private void tbPrice_TextChanged(object sender, EventArgs e) { }
        private void tbCat_TextChanged(object sender, EventArgs e) { }
        private void tbMods_TextChanged(object sender, EventArgs e) { }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ViewChanger.ChangeView(new LoginScreen());
        }

        private void managerMainButton_Click(object sender, EventArgs e)
        {
            ViewChanger.ChangeView(new ManagerMainScreen(employeeID));
        }
    }
}