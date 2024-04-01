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
        NavigationControl navigationControl;
        MediaTab mediaTab;

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
                navigationControl.Display(0);
                ptbNavChat.BackColor = Color.SeaShell;
                ptbNavMedia.BackColor = Color.White;

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
                    case "Icon":
                        IconBlock iconBlock = new IconBlock();
                        iconBlock.SetUpIconBlock(loggedUser.PathToAvatar, chatContent.Content, chatContent.TimeStamp);
                        flpChat.Controls.Add(iconBlock);
                        break;
                    case "Video":
                        VideoBlock videoBlock = new VideoBlock();
                        videoBlock.SetUpVideoBlock(loggedUser.PathToAvatar, chatContent.Content, chatContent.TimeStamp);
                        flpChat.Controls.Add(videoBlock);
                        break;
                }
            }
            flpChat.AutoScrollPosition = new Point(0, flpChat.VerticalScroll.Maximum);
        }

        private void ChatWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void ChatWindows_Load(object sender, EventArgs e)
        {
            LoadUsers();
            foreach (Control control in flpFriendList.Controls)
            {
                control.Click += UserControl_Click;
            }
            SetCurrentLoggedInUser();
            mediaTab = new MediaTab(loggedUser.Id, currentChatUserId)
            {
                Dock = DockStyle.Fill
            };
            navigationControl = new NavigationControl(pnlTabChat, mediaTab);

            SetUpIcons();
            // Them su kien click cho moi icon
            foreach (Control control in panelIcons.Controls)
            {
                control.Click += Icon_Click;
            }

        }

        private void Icon_Click(object sender, EventArgs e)
        {
            // Lay icon tu control
            CircularPicturebox pictureBox = (CircularPicturebox)sender;
            string iconPath = pictureBox.ImageLocation;
            string time = DateTime.Now.ToString("h:mm:ss tt");

            // hien thi len ui
            AppendIconMessage(iconPath, time);


            // luu vao file
            ChatContent chatContent = new ChatContent(loggedUser.Id, currentChatUserId, "Icon", iconPath, time);
            chatContents.Add(chatContent);
            ChatServices.SaveToFile(chatContents, loggedUser.Id, currentChatUserId);

        }

        private void AppendIconMessage(string iconPath, string time)
        {
            IconBlock iconBlock = new IconBlock();
            iconBlock.SetUpIconBlock(loggedUser.PathToAvatar, iconPath, time);
            flpChat.Controls.Add(iconBlock);
            flpChat.AutoScrollPosition = new Point(0, flpChat.VerticalScroll.Maximum);
        }

        private void SetUpIcons()
        {
            ptbEmo.Image = Image.FromFile(ChatServices.IconDirectory + "emo.png");
            ptbEmo1.Image = Image.FromFile(ChatServices.IconDirectory + "emo1.png");
            ptbEmo2.Image = Image.FromFile(ChatServices.IconDirectory + "emo2.png");
            ptbEmo3.Image = Image.FromFile(ChatServices.IconDirectory + "emo3.png");
            ptbEmo4.Image = Image.FromFile(ChatServices.IconDirectory + "emo4.png");
            ptbEmo5.Image = Image.FromFile(ChatServices.IconDirectory + "emo5.png");
            ptbEmo6.Image = Image.FromFile(ChatServices.IconDirectory + "emo6.png");
            ptbEmo7.Image = Image.FromFile(ChatServices.IconDirectory + "emo7.png");
            ptbEmo8.Image = Image.FromFile(ChatServices.IconDirectory + "emo8.png");

            ptbEmo.ImageLocation = ChatServices.IconDirectory + "emo.png";
            ptbEmo1.ImageLocation = ChatServices.IconDirectory + "emo1.png";
            ptbEmo2.ImageLocation = ChatServices.IconDirectory + "emo2.png";
            ptbEmo3.ImageLocation = ChatServices.IconDirectory + "emo3.png";
            ptbEmo4.ImageLocation = ChatServices.IconDirectory + "emo4.png";
            ptbEmo5.ImageLocation = ChatServices.IconDirectory + "emo5.png";
            ptbEmo6.ImageLocation = ChatServices.IconDirectory + "emo6.png";
            ptbEmo7.ImageLocation = ChatServices.IconDirectory + "emo7.png";
            ptbEmo8.ImageLocation = ChatServices.IconDirectory + "emo8.png";

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

                flpFriendList.Controls.Add(userDisplay);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string content = tbMessage.Texts;
            string time = DateTime.Now.ToString("h:mm:ss tt");

            // luu vao file
            ChatContent chatContent = new ChatContent(loggedUser.Id, currentChatUserId, "Text", content, time);
            chatContents.Add(chatContent);
            ChatServices.SaveToFile(chatContents, loggedUser.Id, currentChatUserId);

            // hien thi len ui
            AppendTextMessage(content, time);
            
            tbMessage.Texts = "";
        }

        private void AppendTextMessage(string content, string time)
        {
            MessageBlock messageBlock = new MessageBlock();
            messageBlock.SetUpMessageBlock(
                loggedUser.PathToAvatar,
                content,
                time);
            flpChat.Controls.Add(messageBlock);
            flpChat.AutoScrollPosition = new Point(0, flpChat.VerticalScroll.Maximum);
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
            AppendImageMessage(openFileDialog.FileNames, time);

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
                string destPath = ChatServices.MediaDirectory + fileName;
                File.Copy(path, destPath, true);
            }
        }

        private void AppendImageMessage(string[] fileNames, string time)
        {
            foreach (string path in fileNames)
            {
                ImageBlock imageBlock = new ImageBlock();
                imageBlock.SetUpImageBlock(loggedUser.PathToAvatar, path, time);
                flpChat.Controls.Add(imageBlock);
                flpChat.AutoScrollPosition = new Point(0, flpChat.VerticalScroll.Maximum);

            }
        }

        private void ptbBrowseVideo_Click(object sender, EventArgs e)
        {
            // Open file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video files (*.mp4, *.avi, *.flv) | *.mp4; *.avi; *.flv";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string time = DateTime.Now.ToString("h:mm:ss tt");

            // copy image to media folder
            CopyToStorage(openFileDialog.FileNames);

            // append to flow layout panel
            AppendVideoMessage(openFileDialog.FileNames, time);

            // save to file
            foreach (string path in openFileDialog.FileNames)
            {
                ChatContent chatContent = new ChatContent(loggedUser.Id, currentChatUserId, "Video", path, time);
                chatContents.Add(chatContent);
                ChatServices.SaveToFile(chatContents, loggedUser.Id, currentChatUserId);
            }
        }

        private void AppendVideoMessage(string[] fileNames, string time)
        {
            foreach (string path in fileNames)
            {
                VideoBlock videoBlock = new VideoBlock();
                videoBlock.SetUpVideoBlock(loggedUser.PathToAvatar, path, time);
                flpChat.Controls.Add(videoBlock);
                flpChat.AutoScrollPosition = new Point(0, flpChat.VerticalScroll.Maximum);
            }
        }



        private void ptbNavChat_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            ptbNavChat.BackColor = Color.SeaShell;
            ptbNavMedia.BackColor = Color.White;
        }

        private void ptbNavMedia_Click(object sender, EventArgs e)
        {
            mediaTab = new MediaTab(loggedUser.Id, currentChatUserId)
            {
                Dock = DockStyle.Fill
            };

            // get parent control of tabchat
            Panel parentPanel = (Panel)pnlTabChat.Parent;
            parentPanel.Controls.Add(mediaTab);

            navigationControl = new NavigationControl(pnlTabChat, mediaTab);
            navigationControl.Display(1);
            ptbNavMedia.BackColor = Color.SeaShell;
            ptbNavChat.BackColor = Color.White;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            foreach (Control control in flpChat.Controls)
            {
                if (control is MessageBlock messageControl)
                {
                    messageControl.BackColor = Color.SeaShell;
                    // Kiểm tra nội dung của tin nhắn
                    if (messageControl.Message.Contains(tbSearch.Texts))
                    {
                        // Hiển thị tin nhắn hoặc thực hiện hành động khác
                        messageControl.BackColor = Color.Yellow; // Ví dụ: làm sáng tin nhắn tìm thấy
                    }
                }
            }
        }

        private void ptbSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
