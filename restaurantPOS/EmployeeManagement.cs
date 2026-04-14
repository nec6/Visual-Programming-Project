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
        public EmployeeManagement(int employeeID = 0)
        {
            InitializeComponent();
        }

        // ── Form Load: set up ListView columns ──
        private void Current_Enter(object sender, EventArgs e)
        {
            lstEmployees.View = View.Details;
            lstEmployees.FullRowSelect = true;
            lstEmployees.GridLines = true;
            lstEmployees.MultiSelect = false;

            lstEmployees.Columns.Add("Name", 180);
            lstEmployees.Columns.Add("Pay", 120);
            lstEmployees.Columns.Add("Position", 120);
            lstEmployees.Columns.Add("ID", 100);
        }

        // ── Add button (button2) ──
        private void button2_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string pay = tbPay.Text.Trim();
            string id = tbID.Text.Trim();

            // Get position from radio buttons
            string position = "";
            if (radioButton1.Checked)
                position = "Employee";
            else if (radioButton2.Checked)
                position = "Manager";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pay))
            {
                MessageBox.Show("Name and Pay are required.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(pay, out decimal parsedPay))
            {
                MessageBox.Show("Pay must be a valid number.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Please select a Position (Employee or Manager).", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(parsedPay.ToString("F2"));
            item.SubItems.Add(position);
            item.SubItems.Add(id);
            lstEmployees.Items.Add(item);

            // Update employee/manager count display
            UpdateCounts();

            // Clear fields
            tbName.Clear();
            tbPay.Clear();
            tbID.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            tbName.Focus();
        }

        // ── Delete button (btnDel) ──
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete the selected employee?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                lstEmployees.SelectedItems[0].Remove();
                UpdateCounts();
            }
        }

        // ── Exit button (btnExit) ──
        private void btnExit_Click(object sender, EventArgs e)
        {
            Form parentForm = this.ParentForm;
            if (parentForm != null)
            {
                LoginScreen loginScreen = new LoginScreen();
                loginScreen.Show();
                parentForm.Close();
            }
        }

        // ── ListView selection: populate form fields ──
        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedItems.Count > 0)
            {
                ListViewItem selected = lstEmployees.SelectedItems[0];
                tbName.Text = selected.SubItems[0].Text;
                tbPay.Text = selected.SubItems[1].Text;
                tbID.Text = selected.SubItems[3].Text;

                string pos = selected.SubItems[2].Text;
                radioButton1.Checked = (pos == "Employee");
                radioButton2.Checked = (pos == "Manager");
            }
        }

        // ── Count employees and managers and display in textboxes ──
        private void UpdateCounts()
        {
            int empCount = 0;
            int manCount = 0;

            foreach (ListViewItem item in lstEmployees.Items)
            {
                if (item.SubItems[2].Text == "Employee") empCount++;
                else if (item.SubItems[2].Text == "Manager") manCount++;
            }

            tbEmploy.Text = empCount.ToString();
            tbMan.Text = manCount.ToString();
        }

        // ── Stubs required by Designer ──
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void loginScreen2_Load(object sender, EventArgs e) { }
        private void tbName_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
    }
}