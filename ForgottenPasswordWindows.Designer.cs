namespace BaiThucHanh1
{
    partial class ForgottenPasswordWindows
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
            this.lbMessage = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnContinue = new BaiThucHanh1.UserControls.RoundedButton();
            this.tbEmail = new BaiThucHanh1.UserControls.RoundedTb();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(51, 56);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(61, 16);
            this.lbMessage.TabIndex = 2;
            this.lbMessage.Text = "Hãy điền";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(34, 291);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 16);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng nhập";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnContinue.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnContinue.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnContinue.BorderRadius = 8;
            this.btnContinue.BorderSize = 0;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(275, 281);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(150, 40);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Gửi mật khẩu";
            this.btnContinue.TextColor = System.Drawing.Color.White;
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbEmail.BorderRadius = 8;
            this.tbEmail.BorderSize = 1;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.Location = new System.Drawing.Point(80, 136);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.Size = new System.Drawing.Size(250, 35);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Texts = "";
            this.tbEmail.UnderlinedStyle = false;
            // 
            // ForgottenPasswordWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 342);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbMessage);
            this.Name = "ForgottenPasswordWindows";
            this.Text = "ForgottenPasswordWindows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMessage;
        private UserControls.RoundedTb tbEmail;
        private UserControls.RoundedButton btnContinue;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}