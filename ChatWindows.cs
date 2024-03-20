using BaiThucHanh1.Models;
using BaiThucHanh1.Services;
using BaiThucHanh1.UserControls;
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
            LoadUsers();

            // Thêm xử lý sự kiện Click cho mỗi Control trong FlowLayoutPanel
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Click += UserControl_Click;
            }

        }

        // Xử lý sự kiện Click cho các Control
        private void UserControl_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem sender là loại Control nào và thực hiện các hành động tương ứng
            if (sender is UserControl userControl)
            {
                // Lấy thông tin người dùng từ UserControl và truyền nó cho UserControl hiển thị người muốn chat
                string email = ((UserDisplay)userControl).Email;

                // Gọi phương thức để set thông tin người dùng cho UserControl hiển thị người muốn chat
                userDisplay1.SetUserInfo(email);
            }
        }

        private void ChatWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void ChatWindows_Load(object sender, EventArgs e)
        {
            ptbAvatar.Image = Image.FromFile(loggedUser.PathToAvatar);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadUsers()
        {
            SetCurrentUser();

            List<User> users = UserServices.LoadUsersFromFile(); 
            // Loại bỏ người dùng hiện tại khỏi danh sách
            users = users.Where(u => u.Email != loggedUser.Email).ToList();
            AppendUsers(users);
            
        }

        private void SetCurrentUser()
        {
            userDisplay1.Email = loggedUser.Email;
            userDisplay1.FullName = loggedUser.FullName;
            userDisplay1.UserStatus = loggedUser.Status.ToString();
            userDisplay1.SetAvatar(loggedUser.PathToAvatar);
            userDisplay1.SetStatusImage(loggedUser.Status.ToString());
        }

        private void AppendUsers(List<User> users)
        {
            foreach (User user in users)
            {
                UserDisplay userDisplay = new UserDisplay();
                userDisplay.Email = user.Email;
                userDisplay.FullName = user.FullName;
                userDisplay.UserStatus = user.Status.ToString();
                userDisplay.SetAvatar(user.PathToAvatar);
                userDisplay.SetStatusImage(user.Status.ToString());

                flowLayoutPanel1.Controls.Add(userDisplay);
            }
        }
    }
}
