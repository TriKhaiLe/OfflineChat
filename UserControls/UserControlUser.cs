using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
{
    public partial class UserControlUser : UserControl
    {
        int id;
        public UserControlUser()
        {
            InitializeComponent();
        }

        public void LoadData(int id, Image avatar, Image onoff, string name, string text)
        {
            pbAvatar.Image = avatar;
            pbStatus.Image = onoff;
            lbName.Text = name;
            lbCap.Text = text;
            this.id = id;
        }
    }
}
