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

namespace BaiThucHanh1.UserControls
{
    public partial class UserDisplay : UserControl
    {
        private string id = "0";
        public UserDisplay()
        {
            InitializeComponent();
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FullName
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }

        public string UserStatus
        {
            get { return lbStatus.Text; }
            set { lbStatus.Text = value; }
        }

        public void SetAvatar(string imagePath)
        {
            ptbAvatar.Image = Image.FromFile(imagePath);
        }

        public void SetStatusImage(string statusName)
        {
            switch (statusName)
            {
                case "Online":
                    ptbStatus.Image = Image.FromFile("images/online.png");
                    break;
                case "Offline":
                    ptbStatus.Image = Image.FromFile("images/offline.png");
                    break;
                case "Away":
                    ptbStatus.Image = Image.FromFile("images/away.png");
                    break;
                case "Busy":
                    ptbStatus.Image = Image.FromFile("images/busy.png");
                    break;
            }

        }

        internal void SetUserInfo(string id)
        {
            // dùng email để lấy thông tin người dùng
            User user = UserServices.GetUserById(id);
            FullName = user.FullName;
            UserStatus = user.Status.ToString();
            SetAvatar(user.PathToAvatar);
            SetStatusImage(user.Status.ToString());
            
        }
    }
}
