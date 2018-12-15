using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopAppBD
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creates user, shows initial dialog box for loging in, if successful runs main window
            User user = new User();
            LoginForm loginForm = new LoginForm(user);
            loginForm.ShowDialog();
            if(user.IsLogged)
            {
                Application.Run(new MainForm(user));
            }
        }
    }
}
