using BaiThucHanh1.Models;
using BaiThucHanh1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static BaiThucHanh1.Models.User;

namespace BaiThucHanh1.UserControls
{
    public partial class MessageBlock : UserControl
    {
        public string Message
        {
            get { return tbMessage.Texts; }
            set { tbMessage.Texts = value; }
        }

        public string TimeStamp
        {
            get { return lbTimeStamp.Text; }
            set { lbTimeStamp.Text = value; }
        }

        public MessageBlock()
        {
            InitializeComponent();
        }

        internal void SetUpMessageBlock(string avatarPath, string message, string timeStamp)
        {
            // dùng email để lấy thông tin người dùng
            ptbAvatar.Image = Image.FromFile(avatarPath);
            Message = message;
            TimeStamp = timeStamp;

        }

    }
}
