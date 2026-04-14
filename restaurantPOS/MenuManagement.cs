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
        public MenuManagement(int employeeID = 0)
        {
            InitializeComponent();
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

            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(parsedPrice.ToString("F2"));
            item.SubItems.Add(category);
            item.SubItems.Add(modifiers);
            lstEmployees.Items.Add(item);

            tbName.Clear();
            tbPrice.Clear();
            tbCat.Clear();
            tbMods.Clear();
            tbName.Focus();
        }

        // ── Delete button (btnDel) ──
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete the selected item?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                lstEmployees.SelectedItems[0].Remove();
            }
        }

        // ── Exit button (button3) ──
        private void button3_Click(object sender, EventArgs e)
        {
            Form parentForm = this.ParentForm;
            if (parentForm != null)
            {
                LoginScreen loginScreen = new LoginScreen();
                loginScreen.Show();
                parentForm.Close();
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
            lstEmployees.Columns.Add("Modifiers", 180);
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
    }
}