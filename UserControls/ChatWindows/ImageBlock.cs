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
    public partial class ImageBlock : UserControl
    {
        public ImageBlock()
        {
            InitializeComponent();
        }

        internal void SetUpImageBlock(string avatarPath, string path, string time)
        {
            ptbAvatar.Image = Image.FromFile(avatarPath);
            ptbImage.Image = Image.FromFile(path);
            lbTimeStamp.Text = time;
        }
    }
}
