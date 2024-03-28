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
            Services.FilePathManager.AddPath("users", $"{Environment.CurrentDirectory}\\Data\\users.json");
            Services.FilePathManager.AddPath("images", $"{Environment.CurrentDirectory}\\Images\\"); // avatar
            Services.FilePathManager.AddPath("icons", $"{Environment.CurrentDirectory}\\Icons\\");
            Services.FilePathManager.AddPath("media", $"{Environment.CurrentDirectory}\\Media\\"); // video and image from chat
            Services.FilePathManager.AddPath("chatContent", $"{Environment.CurrentDirectory}\\ChatContent\\content.json");

            Application.Run(new LogInWindows());
        }
    }
}
