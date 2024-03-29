namespace BaiThucHanh1.UserControls
{
    partial class MessageBlock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptbAvatar = new BaiThucHanh1.UserControls.CircularPicturebox();
            this.tbMessage = new BaiThucHanh1.UserControls.RoundedTb();
            this.lbTimeStamp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ptbAvatar.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ptbAvatar.BorderColor2 = System.Drawing.Color.HotPink;
            this.ptbAvatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ptbAvatar.BorderSize = 2;
            this.ptbAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbAvatar.GradientAngle = 50F;
            this.ptbAvatar.Location = new System.Drawing.Point(0, 0);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(70, 70);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 0;
            this.ptbAvatar.TabStop = false;
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbMessage.BackColor = System.Drawing.Color.Linen;
            this.tbMessage.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbMessage.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbMessage.BorderRadius = 8;
            this.tbMessage.BorderSize = 1;
            this.tbMessage.Enabled = false;
            this.tbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMessage.Location = new System.Drawing.Point(77, 6);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbMessage.PasswordChar = false;
            this.tbMessage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbMessage.PlaceholderText = "";
            this.tbMessage.Size = new System.Drawing.Size(769, 53);
            this.tbMessage.TabIndex = 1;
            this.tbMessage.Texts = "";
            this.tbMessage.UnderlinedStyle = false;
            // 
            // lbTimeStamp
            // 
            this.lbTimeStamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimeStamp.AutoSize = true;
            this.lbTimeStamp.Location = new System.Drawing.Point(768, 75);
            this.lbTimeStamp.Name = "lbTimeStamp";
            this.lbTimeStamp.Size = new System.Drawing.Size(78, 16);
            this.lbTimeStamp.TabIndex = 2;
            this.lbTimeStamp.Text = "24:24:24 AM";
            // 
            // MessageBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTimeStamp);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.ptbAvatar);
            this.Name = "MessageBlock";
            this.Size = new System.Drawing.Size(850, 105);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPicturebox ptbAvatar;
        private RoundedTb tbMessage;
        private System.Windows.Forms.Label lbTimeStamp;
    }
}
