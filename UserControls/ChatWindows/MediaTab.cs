using BaiThucHanh1.Models;
using BaiThucHanh1.Services;
using BaiThucHanh1.UserControls.MediaWindows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BaiThucHanh1.UserControls.ChatWindows
{
    public partial class MediaTab : UserControl
    {
        public MediaTab(string idFrom, string idTo)
        {
            InitializeComponent();
            List<ChatContent> chats = ChatServices.LoadChatContent(idFrom, idTo);
            LoadMedia(chats);
            UpdateLanguage();
            UpdateUI();
        }

        private void UpdateUI()
        {
            switch (CustomFormManager.CurrentUIMode)
            {
                case "Light":
                    tableLayoutPanel1.BackColor = Color.SeaShell;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    break;
                case "Dark":
                    tableLayoutPanel1.BackColor = Color.Gray;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    break;
            }
        }

        private void UpdateLanguage()
        {
            switch (CustomFormManager.CurrentLanguage)
            {
                case "English":
                    label1.Text = "Photos";
                    label2.Text = "Videos";
                    break;
                case "Tiếng Việt":
                    label1.Text = "Hình ảnh";
                    label2.Text = "Đoạn phim";
                    break;
                default:
                    break;
            }
        }

        private void LoadMedia(List<ChatContent> chats)
        {
            foreach (var chat in chats)
            {
                switch (chat.ContentType)
                {
                    case "Image":
                        MiniImageBlock miniImageBlock = new MiniImageBlock();
                        miniImageBlock.SetUpMiniImageBlock(chat.Content, chat.TimeStamp);
                        flpImages.Controls.Add(miniImageBlock);
                        break;
                    case "Video":
                        MiniVideoBlock miniVideoBlock = new MiniVideoBlock();
                        miniVideoBlock.SetUpMiniVideoBlock(chat.Content, chat.TimeStamp);
                        flpVideos.Controls.Add(miniVideoBlock);
                        break;
                }
            }
        }
    }
}
