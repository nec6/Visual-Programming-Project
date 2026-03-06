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
            // FIX HERE: CHECK IF ORDER EXISTS FOR TABLE, IF IT DOES NOT THEN CREATE ONE, IF IT DOES THEN USE IT
            ViewChanger.ChangeView(new OrderScreen(1, tableSelected, employeeID)); // CHNAGE THIS TO ACCEPT ACTUAL ORDER NUM NOR JUST "1"
        }
    }
}
