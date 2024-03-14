namespace BaiThucHanh1
{
    partial class SignUpWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpWindows));
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.Label();
            this.roundedButton1 = new BaiThucHanh1.UserControls.RoundedButton();
            this.btnSignup = new BaiThucHanh1.UserControls.RoundedButton();
            this.tbName = new BaiThucHanh1.UserControls.RoundedTb();
            this.tbPass = new BaiThucHanh1.UserControls.RoundedTb();
            this.tbEmail = new BaiThucHanh1.UserControls.RoundedTb();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbAvatar
            // 
            resources.ApplyResources(this.ptbAvatar, "ptbAvatar");
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.TabStop = false;
            this.ptbAvatar.Click += new System.EventHandler(this.ptbAvatar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbTitle
            // 
            resources.ApplyResources(this.tbTitle, "tbTitle");
            this.tbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbTitle.Name = "tbTitle";
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundedButton1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButton1.BorderRadius = 8;
            this.roundedButton1.BorderSize = 0;
            resources.ApplyResources(this.roundedButton1, "roundedButton1");
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.ptbAvatar_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSignup.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSignup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignup.BorderRadius = 8;
            this.btnSignup.BorderSize = 0;
            resources.ApplyResources(this.btnSignup, "btnSignup");
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.TextColor = System.Drawing.Color.White;
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Window;
            this.tbName.BorderColor = System.Drawing.Color.Silver;
            this.tbName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbName.BorderRadius = 8;
            this.tbName.BorderSize = 1;
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = false;
            this.tbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbName.PlaceholderText = "Full Name";
            this.tbName.Texts = "";
            this.tbName.UnderlinedStyle = false;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.SystemColors.Window;
            this.tbPass.BorderColor = System.Drawing.Color.Silver;
            this.tbPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbPass.BorderRadius = 8;
            this.tbPass.BorderSize = 1;
            resources.ApplyResources(this.tbPass, "tbPass");
            this.tbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPass.Multiline = false;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = true;
            this.tbPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPass.PlaceholderText = "Password";
            this.tbPass.Texts = "";
            this.tbPass.UnderlinedStyle = false;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmail.BorderColor = System.Drawing.Color.Silver;
            this.tbEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbEmail.BorderRadius = 8;
            this.tbEmail.BorderSize = 1;
            resources.ApplyResources(this.tbEmail, "tbEmail");
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = false;
            this.tbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.Texts = "";
            this.tbEmail.UnderlinedStyle = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // SignUpWindows
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptbAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpWindows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpWindows_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.RoundedTb tbPass;
        private UserControls.RoundedTb tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tbTitle;
        private UserControls.RoundedButton btnSignup;
        private UserControls.RoundedButton roundedButton1;
        private UserControls.RoundedTb tbEmail;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}