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
        private List<User> users = new List<User>();
        private string filePath = "users.json";
        private string avatarPath = "";

        public ChatWindows()
        {
            InitializeComponent();
        }
        private void GetAllUsers()
        {
            users = LoadFromFile();
            foreach (User user in users)
            {
                lbHoten.Text = user.FullName;
            }
        }

        private List<User> LoadFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<User>>(json);
            }
            return new List<User>();
        }

        private void ChatWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
