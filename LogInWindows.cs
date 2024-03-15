using BaiThucHanh1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
{
    public partial class LogInWindows : Form
    {
        Color signupButtonColor = ColorTranslator.FromHtml("#1877f2"); // Chuyển đổi mã màu hex sang Color
        Color loginButtonColor = ColorTranslator.FromHtml("#36a420"); // Chuyển đổi mã màu hex sang Color

        public LogInWindows()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CustomFormManager.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            btnLogin.BackColor = loginButtonColor;
            btnSignup.BackColor = signupButtonColor;
            comboBox1.SelectedItem = "English";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPass.Text;
            Services.UserServices.LoadUsersFromFile();

            // Example method to check if user exists
            if (Services.UserServices.IsUserExists(email, password))
            {
                Hide();
                ChatWindows homeWindows = new ChatWindows();
                homeWindows.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password");
            }
        }

        private void LogInWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUpWindows signUpWindows = new SignUpWindows();
            signUpWindows.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = comboBox1.SelectedItem.ToString();
            if (CustomFormManager.CurrentLanguage == selectedLanguage)
                return;

            switch (selectedLanguage)
            {
                case "English":
                    CustomFormManager.CurrentLanguage = "English";
                    break;
                case "Tiếng Việt":
                    CustomFormManager.CurrentLanguage = "Tiếng Việt";
                    break;
                default:
                    break;
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            switch (CustomFormManager.CurrentLanguage)
            {
                case "English":
                    btnLogin.Text = "Log In";
                    btnSignup.Text = "Sign Up";
                    tbEmail.PlaceholderText = "Email";
                    tbPass.PlaceholderText = "Password";
                    label1.Text = "Language";
                    linkLabel1.Text = "Forgotten password?";
                    break;

                case "Tiếng Việt":
                    btnLogin.Text = "Đăng nhập";
                    btnSignup.Text = "Đăng ký";
                    tbEmail.PlaceholderText = "Email";
                    tbPass.PlaceholderText = "Mật khẩu";
                    label1.Text = "Ngôn ngữ";
                    linkLabel1.Text = "Quên mật khẩu?";
                    break;
                default:
                    break;
            }
        }

        private void LogInWindows_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void LogInWindows_Paint(object sender, PaintEventArgs e)
        {
            Color c1 = ColorTranslator.FromHtml("#fdfcff"); // Chuyển đổi mã màu hex sang Color
            Color c2 = ColorTranslator.FromHtml("#00ffa2"); // Chuyển đổi mã màu hex sang Color


            // Tạo một đối tượng LinearGradientBrush với màu gradient
            LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(Width, Height),
                c1, // Màu bắt đầu của gradient
                c2); // Màu kết thúc của gradient

            // Vẽ hình chữ nhật sử dụng LinearGradientBrush
            e.Graphics.FillRectangle(brush, ClientRectangle);

        }
    }
}
