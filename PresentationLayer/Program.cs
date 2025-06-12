using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;

namespace PresentationLayer
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

            StartUp Sp = new StartUp();
            Sp.ShowDialog();

            
            if (Sp.found)
                Application.Run(new EMainMenuForm());
        }
    }
}
