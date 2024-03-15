using BaiThucHanh1.Models;
using Newtonsoft.Json;
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

namespace BaiThucHanh1
{
    public partial class ChatWindows : Form
    {
        User loggedUser = new User();
        public ChatWindows(User user)
        {
            InitializeComponent();
            loggedUser = user;
        }

        private void ChatWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void ChatWindows_Load(object sender, EventArgs e)
        {
            lbStatus.Text = loggedUser.Status.ToString();
            ptbAvatar.Image = Image.FromFile(loggedUser.PathToAvatar);

        }
    }
}
