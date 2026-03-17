using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace restaurantPOS
{
    public partial class managerApprovalPopup : Form
    {
        public int employeeID;
        public managerApprovalPopup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Get employee ID from textbox, if textbox is empty set employeeID to 0
        {
            if (idTextbox.Text != "")
            {
                try // Prevents crashing if user enter a non-numeric value in the textbox, if that happens employeeID is set to 0 (invalid login)
                {
                    employeeID = Convert.ToInt32(idTextbox.Text);
                }
                catch 
                {
                    employeeID = 0;
                 };

            }
            else
            {
                employeeID = 0;
            }
        }
    }
}
