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
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
{
    public partial class SignUpWindows : Form
    {
        private string avatarPath = "";
        Color signupButtonColor = ColorTranslator.FromHtml("#1877f2"); // Chuyển đổi mã màu hex sang Color

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SignUpWindows_Load(object sender, EventArgs e)
        {
            btnSignup.BackColor = signupButtonColor;
            btnAvatar.BackColor = signupButtonColor;
            UpdateUI();
        }

        private void UpdateUI()
        {
            switch (CustomFormManager.CurrentLanguage)
            {
                case "English":
                    btnSignup.Text = "Sign Up";
                    btnAvatar.Text = "Choose your avatar";
                    tbName.PlaceholderText = "Your Full Name";
                    tbEmail.PlaceholderText = "Email";
                    tbPass.PlaceholderText = "Password";
                    lbTitle.Text = "Sign Up";
                    break;

                case "Tiếng Việt":
                    btnSignup.Text = "Đăng ký";
                    btnAvatar.Text = "Chọn ảnh đại diện";
                    tbName.PlaceholderText = "Họ và tên";
                    tbEmail.PlaceholderText = "Email";
                    tbPass.PlaceholderText = "Mật khẩu";
                    lbTitle.Text = "Đăng ký";
                    break;
                default:
                    break;
            }
        }

        private void llLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // show login form and close this form
            Close();

        }
    }
}

