using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace restaurantPOS
{
    public static class ViewChanger
    {
        private static Panel _host;
        private static Stack<UserControl> _history = new Stack<UserControl>();

        public static void Initialize(Panel screenHost)
        {
            _host = screenHost;
        }

        public static void ChangeView(UserControl screen)
        {
            if (_host == null)
            {
                throw new Exception("ViewChanger has not been initialized.");
            }

            if (_host.Controls.Count > 0)
            {
                UserControl currentScreen = _host.Controls[0] as UserControl;

                if (currentScreen != null)
                {
                    _history.Push(currentScreen);
                }
            }

            _host.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            _host.Controls.Add(screen);
        }

        public static void GoBack()
        {
            if (_host == null)
            {
                throw new Exception("ViewChanger has not been initialized.");
            }

            if (_history.Count > 0)
            {
                UserControl previousScreen = _history.Pop();
                _host.Controls.Clear();
                previousScreen.Dock = DockStyle.Fill;
                _host.Controls.Add(previousScreen);
            }
        }

        public static void ClearHistory()
        {
            _history.Clear();
        }
    }
}