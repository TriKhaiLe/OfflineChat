﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1.UserControls
{
    public partial class IconBlock : UserControl
    {
        public IconBlock()
        {
            InitializeComponent();
        }

        internal void SetUpIconBlock(string pathToAvatar, string iconPath, string time)
        {
            ptbAvatar.Image = Image.FromFile(pathToAvatar);
            ptbIcon.Image = Image.FromFile(iconPath);
            lbTimeStamp.Text = time;
        }
    }
}
