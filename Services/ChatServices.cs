using BaiThucHanh1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh1.Services
{
    public static class ChatServices
    {
        public static string contentDirectory = $"{Environment.CurrentDirectory}\\ChatContent\\";
        public static string mediaDirectory = $"{Environment.CurrentDirectory}\\Media\\";
        public static string iconDirectory = $"{Environment.CurrentDirectory}\\Icons\\";

        public static void SaveToFile(List<ChatContent> chats, string idFrom, string idTo)
        {
            // tao duong dan den thu muc chua noi dung chat cua nguoi gui
            string fromDirectory = $"{contentDirectory}\\{idFrom}";
            if (!Directory.Exists(fromDirectory))
                Directory.CreateDirectory(fromDirectory);

            string json = JsonConvert.SerializeObject(chats);
            string filePath = $"{fromDirectory}\\{idTo}.json";
            File.WriteAllText(filePath, json);
            
        }

        internal static List<ChatContent> LoadChatContent(string idFrom, string idTo)
        {
            string filePath = $"{contentDirectory}\\{idFrom}\\{idTo}.json";

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<ChatContent> chats = JsonConvert.DeserializeObject<List<ChatContent>>(json);
                return chats == null ? new List<ChatContent>() : chats;
            }
            return new List<ChatContent>();
        }
    }
}
