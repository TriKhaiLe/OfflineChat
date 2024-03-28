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
        string currentChatUserId = "0";
        List<ChatContent> chatContents = new List<ChatContent>();

        public ChatWindows(User user)
        {
            InitializeComponent();

            loggedUser = user;
        }

        // Xử lý sự kiện Click cho các Control
        private void UserControl_Click(object sender, EventArgs e)
        {
            if (sender is UserControl userControl)
            {
                currentChatUserId = ((UserDisplay)userControl).Id;
                ChatUserDisplay.SetUserInfo(currentChatUserId);

                // Load nội dung chat giữa 2 người
                chatContents = ChatServices.LoadChatContent(loggedUser.Id, currentChatUserId);
                ReloadChatContent(chatContents);
            }
        }

        private void ReloadChatContent(List<ChatContent> chatContents)
        {
            flpChat.Controls.Clear();
            foreach (ChatContent chatContent in chatContents)
            {
                switch (chatContent.ContentType)
                {
                    case "Text":
                        MessageBlock messageBlock = new MessageBlock();
                        messageBlock.SetUpMessageBlock(loggedUser.PathToAvatar, chatContent.Content, chatContent.TimeStamp);
                        flpChat.Controls.Add(messageBlock);
                        break;
                    //case "image":
                    //    ImageBlock imageBlock = new ImageBlock();
                    //    imageBlock.SetUpImageBlock(
                    //                                   chatContent.SenderAvatarPath,
                    //                                                              chatContent.Content,
                    //                                                                                         chatContent.Time);
                    //    flpChat.Controls.Add(imageBlock);
                    //    break;
                    //case "video":
                    //    VideoBlock videoBlock = new VideoBlock();
                    //    videoBlock.SetUpVideoBlock(
                    //                                   chatContent.SenderAvatarPath,
                    //                                                              chatContent.Content,
                    //                                                                                         chatContent.Time);
                    //    flpChat.Controls.Add(videoBlock);
                    //    break;
                }
            }
        }

        private void ChatWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void ChatWindows_Load(object sender, EventArgs e)
        {
            LoadUsers();

            // Thêm xử lý sự kiện Click cho mỗi Control trong FlowLayoutPanel
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Click += UserControl_Click;
            }

            SetCurrentLoggedInUser();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadUsers()
        {
            List<User> users = UserServices.LoadUsersFromFile(); 
            // Loại bỏ người dùng hiện tại khỏi danh sách
            users = users.Where(u => u.Id != loggedUser.Id).ToList();
            AppendUsers(users);

            // Lấy người dùng đầu list làm người chat mặc định
            currentChatUserId = users[0].Id;
            ChatUserDisplay.SetUserInfo(currentChatUserId);
            chatContents = ChatServices.LoadChatContent(loggedUser.Id, currentChatUserId);
            ReloadChatContent(chatContents);
        }


        private void SetCurrentLoggedInUser()
        {
            LoggedInUserDisplay.Id = loggedUser.Id;
            LoggedInUserDisplay.FullName = loggedUser.FullName;
            LoggedInUserDisplay.UserStatus = loggedUser.Status.ToString();
            LoggedInUserDisplay.SetAvatar(loggedUser.PathToAvatar);
            LoggedInUserDisplay.SetStatusImage(loggedUser.Status.ToString());
        }

        private void AppendUsers(List<User> users)
        {
            foreach (User user in users)
            {
                UserDisplay userDisplay = new UserDisplay();
                userDisplay.Id = user.Id;
                userDisplay.FullName = user.FullName;
                userDisplay.UserStatus = user.Status.ToString();
                userDisplay.SetAvatar(user.PathToAvatar);
                userDisplay.SetStatusImage(user.Status.ToString());

                flowLayoutPanel1.Controls.Add(userDisplay);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string avatarPath = loggedUser.PathToAvatar;
            string content = tbMessage.Texts;
            string time = DateTime.Now.ToString("h:mm:ss tt");

            // luu vao file
            ChatContent chatContent = new ChatContent(loggedUser.Id, currentChatUserId, "Text", content, time);
            chatContents.Add(chatContent);
            ChatServices.SaveToFile(chatContents, loggedUser.Id, currentChatUserId);

            // hien thi len ui
            MessageBlock messageBlock = new MessageBlock();
            messageBlock.SetUpMessageBlock(
                avatarPath, 
                content,
                time);
            flpChat.Controls.Add(messageBlock);
            
            tbMessage.Texts = "";
        }

        private void tbMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if user press enter, fire btnSend_Click
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                btnSend.PerformClick();
            }
        }

    }
}
