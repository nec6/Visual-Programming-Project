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
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ViewChanger.ChangeView(new LoginScreen()); // Return to login screen when exit button is clicked.
        }

        private void employeeSalesButton_Click(object sender, EventArgs e)
        {
            employeeCategoryLabel.Text = "Employee Name";
        }
    }
}
