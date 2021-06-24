using gescom.create.Models;
using System;
using System.Windows.Forms;

namespace GBASE
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            using (var app = new SingleInstanceApp("{a06f1b39-9c40-4b52-963e-c4dca5c76b1c}"))
            {
                if (app.IsRunning()) return;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (CreateHelpers.IsConnected())
                {
                    Application.Run(new MainForm());
                }
            }
        }
    }
}