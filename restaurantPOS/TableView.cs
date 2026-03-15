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
    public partial class TableView : UserControl
    {
        private int employeeID;
        public TableView(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            string employeeName = DatabaseHandler.GetEmployeeName(employeeID);
            employeeNameLabel.Text = "Logged In: " + employeeName;
            this.Load += TableView_Load; 
        }

        private void TableView_Load(object sender, EventArgs e)
        {
            foreach (Control item in tablesPanel.Controls)
            {
                if (item is Button button)
                {
                    if (button.Tag != null)
                    {
                        if (DatabaseHandler.OrderExists(Convert.ToInt32(button.Tag)) != 0)
                        {
                            button.BackColor = Color.LightGreen; // Change the color of the button to green if there is an open order for that table.
                            if (DatabaseHandler.VerifyOpenTableOwner(Convert.ToInt32(button.Tag), employeeID) != 1)
                            {
                                button.BackColor = Color.LightCoral; // If open order belongs to different employee, show different color for that table
                            }
                        }
                    }
                }
            }
        }

        private void TableButton_Click(object sender, EventArgs e) // Opens table's active order if one exists, if one doesnt exist then one is created
        {
            Button clickedTable = (Button)sender;
            int tableSelected = Convert.ToInt32(clickedTable.Tag);
            
            int orderNum;
            if (DatabaseHandler.OrderExists(tableSelected) == 0)
            {
                DatabaseHandler.CreateOrder(employeeID, tableSelected);
                orderNum = DatabaseHandler.GetOpenOrderNum(tableSelected);
            }
            else
            {
                if (DatabaseHandler.VerifyOpenTableOwner(tableSelected, employeeID) == 0) // Do nothing if another employee has an open check on selected table
                {
                    return;
                }
                orderNum = DatabaseHandler.GetOpenOrderNum(tableSelected);
            }
            ViewChanger.ChangeView(new OrderScreen(orderNum, tableSelected, employeeID));
        }

        private void exitButton_Click(object sender, EventArgs e) // Return to login screen
        {
            ViewChanger.ChangeView(new LoginScreen());
        }
    }
}
