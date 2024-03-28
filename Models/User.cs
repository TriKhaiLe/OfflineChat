using BaiThucHanh1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh1.Models
{
    public class User
    {
        public enum UserStatus
        {
            Online,
            Offline,
            Away,
            Busy
        }

        public string Id { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PathToAvatar { get; set; }
        public UserStatus Status { get; set; }

        public User()
        {
            Id = "0";
            Status = UserStatus.Online;
            FullName = "Unknown";
            Password = "Unknown";
            Email = "Unknown";
            PathToAvatar = FilePathManager.GetPath("images") + "defaultAvatar.png";
        }

        public User(string fullName, string password, string email, string pathToAvatar)
        {
            GenerateId();

            FullName = fullName;
            Password = password;
            Email = email;
            PathToAvatar = pathToAvatar;
            Status = GetRandomStatus();
        }

        private void GenerateId()
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second.ToString();
            string millisecond = DateTime.Now.Millisecond.ToString();

            Id = day + month + year + hour + minute + second + millisecond;
        }

        private UserStatus GetRandomStatus()
        {
            Array values = Enum.GetValues(typeof(UserStatus));
            Random random = new Random();
            return (UserStatus)values.GetValue(random.Next(values.Length));
        }
    }
}
