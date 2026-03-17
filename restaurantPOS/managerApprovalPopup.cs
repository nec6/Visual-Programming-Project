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

        private void button1_Click(object sender, EventArgs e)
        {
            employeeID = Convert.ToInt32(idTextbox.Text);
        }
    }
}
