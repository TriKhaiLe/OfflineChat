using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BaiThucHanh1.UserControls.MediaWindows
{
    public partial class MiniImageBlock : UserControl
    {
        public MiniImageBlock()
        {
            InitializeComponent();
        }

        internal void SetUpMiniImageBlock(string path, string time)
        {
            ptbImage.Image = Image.FromFile(path);
            lbTimeStamp.Text = time;
        }
    }
}
