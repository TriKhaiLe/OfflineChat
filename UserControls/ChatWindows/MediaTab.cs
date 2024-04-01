using BaiThucHanh1.Models;
using BaiThucHanh1.Services;
using BaiThucHanh1.UserControls.MediaWindows;
using System;
using System.Collections.Generic;
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
