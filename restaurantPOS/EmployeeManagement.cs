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
    public partial class EmployeeManagement : UserControl
    {
        private int employeeID;
        public EmployeeManagement(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
        }
    }
}
