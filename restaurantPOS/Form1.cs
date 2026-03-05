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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ViewChanger.Initialize(screenHost);
            ViewChanger.ChangeView(new OrderScreen(1,1)); // Initializes the login screen on program startup.
            DatabaseHandler.Initialize(); // Initialize database on startup.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
