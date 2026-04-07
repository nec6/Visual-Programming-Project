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
            button1.Image = Properties.Resources.icons8_menu_64;
            button2.Image = Properties.Resources.icons8_employee_40;
            button4.Image = Properties.Resources.icons8_report_48;
            button3.Image = Properties.Resources.icons8_table_64;
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

        private void button2_Click(object sender, EventArgs e)
        {
            ViewChanger.ChangeView(new EmployeeManagement(employeeID));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewChanger.ChangeView(new MenuManagement(employeeID));
        }
    }
}
