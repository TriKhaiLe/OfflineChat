using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PathToAvatar { get; set; }

        public User(string fullName, string password, string email, string pathToAvatar)
        {
            FullName = fullName;
            Password = password;
            Email = email;
            PathToAvatar = pathToAvatar;
        }
    }
}
