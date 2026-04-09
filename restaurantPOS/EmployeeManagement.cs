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
            lstEmployees.Columns.Add("Name", 368);
            lstEmployees.Columns.Add("Employee ID", 200);
            lstEmployees.Columns.Add("Role", 200);
            lstEmployees.Columns.Add("Pay", 100);
            updateEmployees();
        }

        private void addEmployee_Click(object sender, EventArgs e) // CHANGE TO CHECK IF EMPLOYEE WITH ID ALREADY EXISTS
        {
            int idToAdd = Convert.ToInt32(tbID.Text);
            string nameToAdd = tbName.Text;
            string employeeTypeToAdd = null;
            decimal pay = Convert.ToDecimal(tbPay.Text);
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

            DatabaseHandler.addEmployee(idToAdd, nameToAdd, employeeTypeToAdd, pay);
            updateEmployees();
        }

        private void updateEmployees()
        {
            lstEmployees.Items.Clear();
            foreach (employee item in DatabaseHandler.GetAllEmployees())
            {
                ListViewItem listItem = new ListViewItem(item.name);
                listItem.SubItems.Add(item.employeeID.ToString());
                listItem.SubItems.Add(item.role);
                listItem.SubItems.Add(item.pay.ToString());
                lstEmployees.Items.Add(listItem);
            }
        }

        private void removeEmployeeButton_Click(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedItems.Count == 0) // Do nothing if no employee is selected, prevents crash
            {
                return;
            }

            ListViewItem item = lstEmployees.SelectedItems[0];
            int employeeToRemove = Convert.ToInt32(item.SubItems[1].Text);

            DatabaseHandler.removeEmployee(employeeToRemove);
            updateEmployees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewChanger.ChangeView(new LoginScreen());
        }

    }
}
