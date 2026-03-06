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
        }

        private void TableButton_Click(object sender, EventArgs e)
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
                orderNum = DatabaseHandler.GetOpenOrderNum(tableSelected);
            }
            ViewChanger.ChangeView(new OrderScreen(orderNum, tableSelected, employeeID));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ViewChanger.ChangeView(new LoginScreen());
        }
    }
}
