using BaiThucHanh1.Models;
using BaiThucHanh1.Services;
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
    public partial class SignUpWindows : Form
    {
        private string avatarPath = "";

        public SignUpWindows()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CustomFormManager.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            avatarPath = FilePathManager.GetFilePath("images") + "defaultAvatar.png";
            ptbAvatar.Image = Image.FromFile(avatarPath);
        }

        private void ptbAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatarPath = openFileDialog.FileName;
                ptbAvatar.Image = Image.FromFile(avatarPath);
            }

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            // check email exists
            if (UserServices.IsEmailExists(tbEmail.Texts))
            {
                MessageBox.Show("Email already exists");
                return;
            }

            // add user
            UserServices.AddUser(tbName.Texts, tbPass.Texts, tbEmail.Texts, avatarPath);

            MessageBox.Show("Sign up successfully");
            this.Close();
        }

        private void SignUpWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

