 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantPOS
{
    public partial class LoginScreen : UserControl
    {

        public LoginScreen()
        {
            InitializeComponent();
            RoundPanel(panelNumpad, 20);
        }



        private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel.Region = new Region(path);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null)
            {
                EmployeeID.Text += btn.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (EmployeeID.Text.Length > 0)
            {
                EmployeeID.Text = EmployeeID.Text.Substring(0, EmployeeID.Text.Length - 1);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string enteredID = EmployeeID.Text.Trim();
            if (string.IsNullOrEmpty(enteredID))
            {
                return; // Ignore empty input
            }
            int idInteger = Convert.ToInt32(enteredID);

            string employeeType = null;
            if (DatabaseHandler.EmployeeExists(idInteger) == 1) // Check if employee exists before trying to get type
            {
                employeeType = DatabaseHandler.GetEmployeeType(idInteger);
            }

            if (string.IsNullOrEmpty(enteredID))
            {
                MessageBox.Show("Please enter an employee ID.");
                return;
            }

            if ((employeeType == "Manager") || (enteredID == "9999"))
            {
                int employeeID = Convert.ToInt32(enteredID);
                ViewChanger.ChangeView(new ManagerMainScreen(employeeID));
            }
            else if ((employeeType == "Employee") || enteredID == "1111" || enteredID == "2222" || enteredID == "3333")
            {
                int employeeID = Convert.ToInt32(enteredID);
                ViewChanger.ChangeView(new TableView(employeeID));
            }
            else
            {
                MessageBox.Show("Invalid ID");
                EmployeeID.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
