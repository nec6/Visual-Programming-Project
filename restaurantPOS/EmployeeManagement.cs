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
    public partial class EmployeeManagement : UserControl
    {
        private int employeeID;
        public EmployeeManagement(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
        }

        private void addEmployee_Click(object sender, EventArgs e) // CHANGE TO CHECK IF EMPLOYEE WITH ID ALREADY EXISTS
        {
            int idToAdd = Convert.ToInt32(tbID.Text);
            string nameToAdd = tbName.Text;
            string employeeTypeToAdd = null;
            if (radioButton1.Checked)
            {
                employeeTypeToAdd = "Employee";
            }
            else if (radioButton2.Checked)
            {
                employeeTypeToAdd = "Manager";
            }
            else
            {
                MessageBox.Show("Please select an employee type.");
                return;
            }

            DatabaseHandler.addEmployee(idToAdd, nameToAdd, employeeTypeToAdd);
        }
    }
}
