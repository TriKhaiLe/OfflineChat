namespace BaiThucHanh1
{
    partial class ChatWindows
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
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.lbAvatar = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbHoten = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Location = new System.Drawing.Point(305, 163);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(87, 70);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAvatar.TabIndex = 14;
            this.ptbAvatar.TabStop = false;
            // 
            // lbAvatar
            // 
            this.lbAvatar.AutoSize = true;
            this.lbAvatar.Location = new System.Drawing.Point(450, 189);
            this.lbAvatar.Name = "lbAvatar";
            this.lbAvatar.Size = new System.Drawing.Size(46, 16);
            this.lbAvatar.TabIndex = 13;
            this.lbAvatar.Text = "Avatar";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(450, 311);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(25, 16);
            this.lbStatus.TabIndex = 12;
            this.lbStatus.Text = "mk";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(450, 253);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(40, 16);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "email";
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Location = new System.Drawing.Point(450, 123);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(40, 16);
            this.lbHoten.TabIndex = 10;
            this.lbHoten.Text = "hoten";
            // 
            // ChatWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptbAvatar);
            this.Controls.Add(this.lbAvatar);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbHoten);
            this.Name = "ChatWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatWindows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatWindows_FormClosing);
            this.Load += new System.EventHandler(this.ChatWindows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.Label lbAvatar;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbHoten;
    }
}