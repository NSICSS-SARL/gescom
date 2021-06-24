using System;
using System.Windows.Forms;

namespace GOPER
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            using (var app = new SingleInstanceApp("{c20b63ff-4512-4b80-90d8-b7e90d7a9328}"))
            {
                if (app.IsRunning()) return;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(3));
            }
        }
    }
}