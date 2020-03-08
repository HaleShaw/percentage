using System;
using System.Windows.Forms;

namespace percentage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TrayIcon trayIcon = new TrayIcon();

            // If there is a parameter, try to set the font by the parameter.
            if (args != null && args.Length == 1)
            {
                try
                {
                    trayIcon.setFont(args[0]);
                }
                catch (Exception e) { }

            }

            Application.Run();
        }
    }
}
