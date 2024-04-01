using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1.UserControls.MediaWindows
{
    public partial class MiniVideoBlock : UserControl
    {
        public MiniVideoBlock()
        {
            InitializeComponent();
        }

        internal void SetUpMiniVideoBlock(string content, string timeStamp)
        {
            axWindowsMediaPlayer1.URL = content;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            lbTimeStamp.Text = timeStamp;
        }
    }
}
