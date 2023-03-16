using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetshop_2._0
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
            FormLogin frmlogin = new FormLogin();
            frmlogin.ShowDialog();
            bool liberado = frmlogin.liberado;
            if (liberado == true)
            {
                Application.Run(new FormPrincipal());
            }

        }
    }
}
