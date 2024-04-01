using BaiThucHanh1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void rbtViet_CheckedChanged(object sender, EventArgs e)
        {
            CustomFormManager.CurrentLanguage = "Tiếng Việt";
            UpdateLanguage();
        }

        private void rbtEng_CheckedChanged(object sender, EventArgs e)
        {
            CustomFormManager.CurrentLanguage = "English";
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            switch (CustomFormManager.CurrentLanguage)
            {
                case "English":
                    label1.Text = "Display mode";
                    rbtLight.Text = "Light mode";
                    rbtDark.Text = "Dark mode";
                    label2.Text = "Language";
                    btnOk.Text = "OK";
                    break;

                case "Tiếng Việt":
                    label1.Text = "Chế độ hiển thị";
                    rbtLight.Text = "Chế độ sáng";
                    rbtDark.Text = "Chế độ tối";
                    label2.Text = "Ngôn ngữ";
                    btnOk.Text = "Hoàn tất";
                    break;
                default:
                    break;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void rbtLight_CheckedChanged(object sender, EventArgs e)
        {
            CustomFormManager.CurrentUIMode = "Light";
            UpdateUIMode();

        }

        private void UpdateUIMode()
        {
            switch (CustomFormManager.CurrentUIMode)
            {
                case "Light":
                    BackColor = Color.SeaShell;
                    label1.ForeColor = Color.Black;
                    rbtLight.ForeColor = Color.Black;
                    rbtDark.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    rbtEng.ForeColor = Color.Black;
                    rbtViet.ForeColor = Color.Black;
                    break;

                case "Dark":
                    BackColor = Color.Gray;
                    label1.ForeColor = Color.White;
                    rbtLight.ForeColor = Color.White;
                    rbtDark.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    rbtEng.ForeColor = Color.White;
                    rbtViet.ForeColor = Color.White;
                    break;
            }
        }

        private void rbtDark_CheckedChanged(object sender, EventArgs e)
        {
            CustomFormManager.CurrentUIMode = "Dark";
            UpdateUIMode();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            if (CustomFormManager.CurrentLanguage == "English")
            {
                rbtEng.Checked = true;
                
            }
            else
            {
                rbtViet.Checked = true;
            }

            if (CustomFormManager.CurrentUIMode == "Light")
            {
                rbtLight.Checked = true;
            }
            else
            {
                rbtDark.Checked = true;
            }
            UpdateLanguage();
            UpdateUIMode();
        }
    }
}
