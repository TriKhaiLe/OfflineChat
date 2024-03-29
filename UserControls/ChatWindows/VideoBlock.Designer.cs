namespace BaiThucHanh1.UserControls.ChatWindows
{
    partial class VideoBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoBlock));
            this.lbTimeStamp = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.ptbAvatar = new BaiThucHanh1.UserControls.CircularPicturebox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTimeStamp
            // 
            this.lbTimeStamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimeStamp.AutoSize = true;
            this.lbTimeStamp.Location = new System.Drawing.Point(754, 217);
            this.lbTimeStamp.Name = "lbTimeStamp";
            this.lbTimeStamp.Size = new System.Drawing.Size(78, 16);
            this.lbTimeStamp.TabIndex = 5;
            this.lbTimeStamp.Text = "24:24:24 AM";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(86, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(200, 200);
            this.axWindowsMediaPlayer1.TabIndex = 6;
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
            this.ptbAvatar.Location = new System.Drawing.Point(10, 0);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(70, 70);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 3;
            this.ptbAvatar.TabStop = false;
            // 
            // VideoBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lbTimeStamp);
            this.Controls.Add(this.ptbAvatar);
            this.Name = "VideoBlock";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.Size = new System.Drawing.Size(840, 250);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPicturebox ptbAvatar;
        private System.Windows.Forms.Label lbTimeStamp;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
