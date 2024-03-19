using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiThucHanh1.Services;
using BaiThucHanh1.Models;

namespace BaiThucHanh1
{
    public partial class ForgottenPasswordWindows : Form
    {
        public ForgottenPasswordWindows()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                // check if email exists
                if (!UserServices.IsEmailExists(tbEmail.Texts))
                {
                    MessageBox.Show("Email does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string password = GetOldPassword(tbEmail.Texts);

                MailMessage mail = new MailMessage();
                mail.From = new System.Net.Mail.MailAddress("facepada81@gmail.com");
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail.From.Address, "srxpugmavmaejmme");
                smtp.Host = "smtp.gmail.com";

                //recipient
                mail.To.Add(new MailAddress(tbEmail.Texts));
                mail.IsBodyHtml = true;
                mail.Subject = "Lấy lại mật khẩu";
                mail.Body = $"Your forgotten password is: {password}";

                //for (int i = 0; i < attachmentFilename.Length; i++)
                //    mail.Attachments.Add(new Attachment(attachmentFilename[i]));

                smtp.Send(mail);
                UserServices.UpdatePassword(tbEmail.Texts, password);
                MessageBox.Show("Email sent successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetOldPassword(string texts)
        {
            User user = UserServices.GetUserByEmail(texts);
            return user.Password;
        }

        private string GenerateNewPassword()
        {
            // generate new password
            string newPassword = Guid.NewGuid().ToString().Substring(0, 8);
            return newPassword;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
