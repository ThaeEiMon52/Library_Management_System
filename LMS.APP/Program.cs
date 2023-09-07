using LMS.APP.Views.FrmMenu;
using System;
//using LMS.APP.Views.Menu;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.APP.Views;
using LMS.APP.Views.LoginForm;


namespace LMS.APP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
