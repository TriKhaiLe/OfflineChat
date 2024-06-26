﻿using BaiThucHanh1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1.Services
{
    public static class UserServices
    {
        public static string filePath = FilePathManager.GetPath("users");

        public static void SaveToFile(List<User> users, string filePath)
        {
            string json = JsonConvert.SerializeObject(users);
            File.WriteAllText(filePath, json);
        }


        // Example method to add a user
        public static void AddUser(string fullName, string password, string email, string avatarPath)
        {
            List<User> users = LoadUsersFromFile();
            users.Add(new User(fullName, password, email, avatarPath));
            SaveToFile(users, filePath);
        }

        public static List<User> LoadUsersFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
                return users == null ? new List<User>() : users;
            }
            return new List<User>();
        }

        public static bool IsUserExists(string email, string password)
        {
            List<User> users = LoadUsersFromFile();
            return users.Any(u => u.Email == email && u.Password == password);
        }

        // login user
        public static User Login(string email, string password)
        {
            List<User> users = LoadUsersFromFile();
            return users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        // check email exists
        public static bool IsEmailExists(string email)
        {
            List<User> users = LoadUsersFromFile();
            return users.Any(u => u.Email == email);
        }

        // get user by email
        public static User GetUserByEmail(string email)
        {
            List<User> users = LoadUsersFromFile();
            return users.FirstOrDefault(u => u.Email == email);
        }

        // get user by id
        public static User GetUserById(string id)
        {
            List<User> users = LoadUsersFromFile();
            return users.FirstOrDefault(u => u.Id == id);
        }

        // update password by email
        public static void UpdatePassword(string email, string newPassword)
        {
            List<User> users = LoadUsersFromFile();
            User user = users.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                user.Password = newPassword;
                SaveToFile(users, filePath);
            }
            else
            {
                MessageBox.Show("Email not found!");
            }
        }
    }
}
