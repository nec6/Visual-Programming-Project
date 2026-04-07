using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantPOS
{
    public static class ViewChanger
    {
        private static Panel _host;

        public static void Initialize(Panel screenHost)
        {
            _host = screenHost;
        }

        public static void ChangeView(UserControl screen) // Used to change screens. Pass screen to change to as argument.
        {
            _host.Controls.Clear();
            screen.Dock = DockStyle.Fill; // Fills the entire form autmoatically
            _host.Controls.Add(screen);
        }
    }
}
