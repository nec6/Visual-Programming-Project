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
    public partial class ReportsScreen : UserControl
    {
        public ReportsScreen()
        {
            InitializeComponent();
            foodSalesButton_Click(foodSalesButton, EventArgs.Empty); // Used to load the sales by menu item when the reports screen is opened initially.
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ViewChanger.ChangeView(new LoginScreen()); // Return to login screen when exit button is clicked.
        }

        private void employeeSalesButton_Click(object sender, EventArgs e)
        {
            salesPanel.Controls.Clear();

            employeeCategoryLabel.Text = "Employee Name";
            quantityLabel.Hide();

            Dictionary<int, decimal> employeeSales = new Dictionary<int, decimal>();

            employeeSales = DatabaseHandler.GetSalesByEmployee();

            int i = 0;
            foreach (KeyValuePair<int, decimal> entry in employeeSales)
            {
                string employeeName = DatabaseHandler.GetEmployeeName(entry.Key);
                decimal salesAmount = entry.Value;
                string backColor = (i % 2 == 0) ? Color.LightGray.Name : Color.LightBlue.Name; // Alternate row colors for readability based on even or odd.
                i++;

                Panel row = new Panel
                {
                    Width = salesPanel.Width - 20,
                    Height = 40,
                    // Margin = new Padding(5)
                    Padding = new Padding(200, 0, 200, 0),
                    BackColor = Color.FromName(backColor)
                };

                int contentWidth = row.Width - row.Padding.Left - row.Padding.Right; // Used to push report labels inward.

                Label nameLabel = new Label
                {
                    Text = employeeName,
                    AutoSize = false,
                    Width = contentWidth / 2,
                    Left = row.Padding.Left,
                    Height = row.Height,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleLeft,
                };

                Label salesLabel = new Label
                {
                    Text = $"${salesAmount:F2}",
                    AutoSize = false,
                    Width = contentWidth / 2,
                    Height = row.Height,
                    Left = row.Width / 2,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleRight,
                };

                row.Controls.Add(nameLabel);
                row.Controls.Add(salesLabel);
                salesPanel.Controls.Add(row);
            }
        }

        private void foodSalesButton_Click(object sender, EventArgs e)
        {
            salesPanel.Controls.Clear();
            employeeCategoryLabel.Text = "Menu Item";
            quantityLabel.Show();
            List<itemSales> itemSalesTotals = new List<itemSales>();

            itemSalesTotals = DatabaseHandler.GetSalesByItem();

            int i = 0;
            foreach (itemSales item in itemSalesTotals)
            {
                string menuItem = item.menuItem;
                int quantity = item.quantity;
                decimal sales = item.totalSales;
                string backColor = (i % 2 == 0) ? Color.LightGray.Name : Color.LightBlue.Name; // Alternate row colors for readability based on even or odd.
                i++;

                Panel row = new Panel
                {
                    Width = salesPanel.Width - 20,
                    Height = 40,
                    Padding = new Padding(200, 0, 200, 0),
                    BackColor = Color.FromName(backColor)
                };

                int contentWidth = row.Width - row.Padding.Left - row.Padding.Right; // Used to push report labels inward.

                Label nameLabel = new Label
                {
                    Text = menuItem,
                    AutoSize = false,
                    Width = contentWidth / 3,
                    Left = row.Padding.Left,
                    Height = row.Height,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleLeft,
                };

                Label quantityLabel = new Label
                {
                    Text = "" + quantity,
                    AutoSize = false,
                    Width = contentWidth / 3,
                    Left = row.Padding.Left + (contentWidth / 3),
                    Height = row.Height,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                };

                Label salesLabel = new Label
                {
                    Text = $"${sales:F2}",
                    AutoSize = false,
                    Width = contentWidth / 3,
                    Left = row.Padding.Left + 2 * (contentWidth / 3),
                    Height = row.Height,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleRight,
                };

                row.Controls.Add(nameLabel);
                row.Controls.Add(quantityLabel);
                row.Controls.Add(salesLabel);
                salesPanel.Controls.Add(row);
            }
        }

        private void button100_Click(object sender, EventArgs e)
        {
            ViewChanger.GoBack();
        }
    }
}
