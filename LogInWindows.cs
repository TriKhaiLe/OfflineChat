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
        Color loginButtonColor = ColorTranslator.FromHtml("#1877f2"); // Chuyển đổi mã màu hex sang Color
        Color signupButtonColor = ColorTranslator.FromHtml("#36a420"); // Chuyển đổi mã màu hex sang Color

        public LogInWindows()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CustomFormManager.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            btnLogin.BackColor = signupButtonColor;
            btnSignup.BackColor = loginButtonColor;
            comboBox1.Text = "English";
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
    }
}
