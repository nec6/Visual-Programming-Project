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
    public partial class ManagerMainScreen : UserControl
    {
        private int employeeID;


        public ManagerMainScreen(int employeeID)
        {

            InitializeComponent();
            this.employeeID = employeeID;
            button1.Image = Image.FromFile(
               @"C:\Users\dadams0753\Pictures\icons8-menu-64.png"
           );
            button2.Image = Image.FromFile(
               @"C:\Users\dadams0753\Pictures\icons8-employee-40.png"
           );
            button4.Image = Image.FromFile(
               @"C:\Users\dadams0753\Pictures\icons8-table-64.png"
           );
            button3.Image = Image.FromFile(
               @"C:\Users\dadams0753\Pictures\icons8-report-48.png"
           );
        }

        private void ManagerMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewChanger.ChangeView(new LoginScreen());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewChanger.ChangeView(new TableView(employeeID));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewChanger.ChangeView(new ReportsScreen());
        }
    }
}
