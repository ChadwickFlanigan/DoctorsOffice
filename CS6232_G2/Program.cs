using CS6232_G2.View;
using System;
using System.Windows.Forms;

namespace CS6232_G2
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
            ///Application.Run(new LoginForm());
            Application.Run(new NurseForm());
        }
    }
}
