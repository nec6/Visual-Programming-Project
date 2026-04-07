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
        private int employeeID;
        public MenuManagement(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
        }
    }
}
