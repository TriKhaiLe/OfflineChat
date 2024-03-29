using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1.UserControls.ChatWindows
{
    public partial class VideoBlock : UserControl
    {
        public VideoBlock()
        {
            InitializeComponent();
        }

        internal void SetUpVideoBlock(string pathToAvatar, string path, string time)
        {
            ptbAvatar.Image = Image.FromFile(pathToAvatar);
            axWindowsMediaPlayer1.URL = path;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            //axWindowsMediaPlayer1.uiMode = "mini";
            lbTimeStamp.Text = time;
        }
    }
}
