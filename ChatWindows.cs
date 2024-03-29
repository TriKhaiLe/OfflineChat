using BaiThucHanh1.Models;
using BaiThucHanh1.Services;
using BaiThucHanh1.UserControls;
using BaiThucHanh1.UserControls.ChatWindows;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BaiThucHanh1
{
    public partial class ChatWindows : Form
    {
        User loggedUser = new User();
        string currentChatUserId = "0";
        List<ChatContent> chatContents = new List<ChatContent>(); // List chứa nội dung chat với người dùng hiện tại

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
                    case "Image":
                        ImageBlock imageBlock = new ImageBlock();
                        imageBlock.SetUpImageBlock(loggedUser.PathToAvatar, chatContent.Content, chatContent.TimeStamp);
                        flpChat.Controls.Add(imageBlock);
                        break;
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
            SetUpIcons();
        }

        private void SetUpIcons()
        {
            ptbEmo.Image = Image.FromFile(ChatServices.iconDirectory + "emo.png");
            ptbEmo1.Image = Image.FromFile(ChatServices.iconDirectory + "emo1.png");
            ptbEmo2.Image = Image.FromFile(ChatServices.iconDirectory + "emo2.png");
            ptbEmo3.Image = Image.FromFile(ChatServices.iconDirectory + "emo3.png");
            ptbEmo4.Image = Image.FromFile(ChatServices.iconDirectory + "emo4.png");
            ptbEmo5.Image = Image.FromFile(ChatServices.iconDirectory + "emo5.png");
            ptbEmo6.Image = Image.FromFile(ChatServices.iconDirectory + "emo6.png");
            ptbEmo7.Image = Image.FromFile(ChatServices.iconDirectory + "emo7.png");
            ptbEmo8.Image = Image.FromFile(ChatServices.iconDirectory + "emo8.png");
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

        private void ptbAvatar_Click(object sender, EventArgs e)
        {
            if (panelIcons.Visible)
            {
                panelIcons.Visible = false;
            }
            else
            {
                panelIcons.Visible = true;
            }
        }

        private void ptbBrowseImg_Click(object sender, EventArgs e)
        {
            // Open file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string avatarPath = loggedUser.PathToAvatar;
            string time = DateTime.Now.ToString("h:mm:ss tt");

            // copy image to media folder
            CopyToStorage(openFileDialog.FileNames);

            // append to flow layout panel
            AppendImageMessage(openFileDialog.FileNames, avatarPath, time);

            // save to file
            foreach (string path in openFileDialog.FileNames)
            {
                ChatContent chatContent = new ChatContent(loggedUser.Id, currentChatUserId, "Image", path, time);
                chatContents.Add(chatContent);
                ChatServices.SaveToFile(chatContents, loggedUser.Id, currentChatUserId);
            }
        }

        private void CopyToStorage(string[] fileNames)
        {
            foreach (string path in fileNames)
            {
                string fileName = Path.GetFileName(path);
                string destPath = ChatServices.mediaDirectory + fileName;
                File.Copy(path, destPath, true);
            }
        }

        private void AppendImageMessage(string[] fileNames, string avatarPath, string time)
        {
            foreach (string path in fileNames)
            {
                ImageBlock imageBlock = new ImageBlock();
                imageBlock.SetUpImageBlock(avatarPath, path, time);
                flpChat.Controls.Add(imageBlock);
            }
        }
    }
}
