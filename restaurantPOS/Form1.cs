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
            DatabaseHandler.Initialize(); // Initialize database on startup.
            ViewChanger.ChangeView(new TableView(1)); // Initializes the login screen on program startup.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
