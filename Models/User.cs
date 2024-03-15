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

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PathToAvatar { get; set; }
        public UserStatus Status { get; set; }

        public User()
        {
            Status = UserStatus.Online;
            FullName = "Unknown";
            Password = "Unknown";
            Email = "Unknown";
            PathToAvatar = FilePathManager.GetFilePath("images") + "defaultAvatar.png";
        }

        public User(string fullName, string password, string email, string pathToAvatar)
        {
            FullName = fullName;
            Password = password;
            Email = email;
            PathToAvatar = pathToAvatar;
            Status = GetRandomStatus();
        }
        private UserStatus GetRandomStatus()
        {
            Array values = Enum.GetValues(typeof(UserStatus));
            Random random = new Random();
            return (UserStatus)values.GetValue(random.Next(values.Length));
        }
    }
}
