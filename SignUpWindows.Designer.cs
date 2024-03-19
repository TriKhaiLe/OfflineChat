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
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnAvatar = new BaiThucHanh1.UserControls.RoundedButton();
            this.btnSignup = new BaiThucHanh1.UserControls.RoundedButton();
            this.tbName = new BaiThucHanh1.UserControls.RoundedTb();
            this.tbPass = new BaiThucHanh1.UserControls.RoundedTb();
            this.tbEmail = new BaiThucHanh1.UserControls.RoundedTb();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.llLogin = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 3);
            this.label2.TabIndex = 30;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTitle.Location = new System.Drawing.Point(12, 23);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(83, 24);
            this.lbTitle.TabIndex = 31;
            this.lbTitle.Text = "Signup";
            // 
            // btnAvatar
            // 
            this.btnAvatar.BackColor = System.Drawing.Color.Blue;
            this.btnAvatar.BackgroundColor = System.Drawing.Color.Blue;
            this.btnAvatar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAvatar.BorderRadius = 8;
            this.btnAvatar.BorderSize = 0;
            this.btnAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvatar.ForeColor = System.Drawing.Color.White;
            this.btnAvatar.Location = new System.Drawing.Point(117, 151);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(147, 31);
            this.btnAvatar.TabIndex = 1;
            this.btnAvatar.Text = "Choose your avatar";
            this.btnAvatar.TextColor = System.Drawing.Color.White;
            this.btnAvatar.UseVisualStyleBackColor = false;
            this.btnAvatar.Click += new System.EventHandler(this.ptbAvatar_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.Blue;
            this.btnSignup.BackgroundColor = System.Drawing.Color.Blue;
            this.btnSignup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignup.BorderRadius = 8;
            this.btnSignup.BorderSize = 0;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(83, 390);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(212, 53);
            this.btnSignup.TabIndex = 32;
            this.btnSignup.Text = "roundedButton1";
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
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.Location = new System.Drawing.Point(13, 206);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbName.PasswordChar = false;
            this.tbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbName.PlaceholderText = "Full Name";
            this.tbName.Size = new System.Drawing.Size(348, 35);
            this.tbName.TabIndex = 29;
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
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPass.Location = new System.Drawing.Point(13, 329);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbPass.Multiline = false;
            this.tbPass.Name = "tbPass";
            this.tbPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbPass.PasswordChar = true;
            this.tbPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPass.PlaceholderText = "Password";
            this.tbPass.Size = new System.Drawing.Size(348, 35);
            this.tbPass.TabIndex = 31;
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
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.Location = new System.Drawing.Point(13, 268);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.Size = new System.Drawing.Size(348, 35);
            this.tbEmail.TabIndex = 30;
            this.tbEmail.Texts = "";
            this.tbEmail.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Location = new System.Drawing.Point(153, 72);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(70, 70);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAvatar.TabIndex = 9;
            this.ptbAvatar.TabStop = false;
            this.ptbAvatar.Click += new System.EventHandler(this.ptbAvatar_Click);
            // 
            // llLogin
            // 
            this.llLogin.AutoSize = true;
            this.llLogin.Location = new System.Drawing.Point(150, 460);
            this.llLogin.Name = "llLogin";
            this.llLogin.Size = new System.Drawing.Size(72, 16);
            this.llLogin.TabIndex = 33;
            this.llLogin.TabStop = true;
            this.llLogin.Text = "Đăng nhập";
            this.llLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLogin_LinkClicked);
            // 
            // SignUpWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 513);
            this.Controls.Add(this.llLogin);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btnAvatar);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptbAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUpWindows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.RoundedTb tbPass;
        private UserControls.RoundedTb tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTitle;
        private UserControls.RoundedButton btnSignup;
        private UserControls.RoundedButton btnAvatar;
        private UserControls.RoundedTb tbEmail;
        private System.Windows.Forms.LinkLabel llLogin;
    }
}