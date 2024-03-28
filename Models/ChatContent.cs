using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh1.Models
{
    public class ChatContent
    {
        public string IdFrom { get; set; }
        public string IdTo { get; set; }
        public enum ContentTypeList
        {
            Text,
            Media,
            Icon
        }
        public string ContentType { get; set; }
        public string Content { get; set; }
        public string TimeStamp { get; set; }

        public ChatContent(string from, string to, string contentType, string content, string time) {
            IdFrom = from;
            IdTo = to;
            ContentType = contentType;
            Content = content;
            TimeStamp = time;
        }
    }
}
