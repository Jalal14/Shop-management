using ShopManagement.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new PasswordRecoverForm());
            //Application.Run(new AdminForm());
            //Application.Run(new EditInformationForm());
            //Application.Run(new SalesmanForm());
            //Application.Run(new AllProductsForm());
            //Application.Run(new SignUpForm());
        }
    }
}
