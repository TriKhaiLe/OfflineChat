using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
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

            // set up file paths
            Services.FilePathManager.AddFilePath("users", $"{Environment.CurrentDirectory}\\Data\\users.json");
            Services.FilePathManager.AddFilePath("images", $"{Environment.CurrentDirectory}\\Images\\");

            Application.Run(new LogInWindows());
        }
    }
}
