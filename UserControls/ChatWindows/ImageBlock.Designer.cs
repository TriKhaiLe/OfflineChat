namespace BaiThucHanh1.UserControls.ChatWindows
{
    partial class ImageBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageBlock));
            this.ptbAvatar = new BaiThucHanh1.UserControls.CircularPicturebox();
            this.ptbImage = new BaiThucHanh1.UserControls.RoundedPictureBox();
            this.lbTimeStamp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
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
            this.ptbAvatar.Location = new System.Drawing.Point(10, 0);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(70, 70);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 2;
            this.ptbAvatar.TabStop = false;
            // 
            // ptbImage
            // 
            this.ptbImage.BorderColor = System.Drawing.Color.Cyan;
            this.ptbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImage.BorderWidth = 3;
            this.ptbImage.CornerRadius = 10;
            this.ptbImage.Image = ((System.Drawing.Image)(resources.GetObject("ptbImage.Image")));
            this.ptbImage.Location = new System.Drawing.Point(86, 3);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(180, 180);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImage.TabIndex = 3;
            this.ptbImage.TabStop = false;
            // 
            // lbTimeStamp
            // 
            this.lbTimeStamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimeStamp.AutoSize = true;
            this.lbTimeStamp.Location = new System.Drawing.Point(754, 167);
            this.lbTimeStamp.Name = "lbTimeStamp";
            this.lbTimeStamp.Size = new System.Drawing.Size(78, 16);
            this.lbTimeStamp.TabIndex = 4;
            this.lbTimeStamp.Text = "24:24:24 AM";
            // 
            // ImageBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTimeStamp);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.ptbAvatar);
            this.Name = "ImageBlock";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.Size = new System.Drawing.Size(840, 200);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPicturebox ptbAvatar;
        private RoundedPictureBox ptbImage;
        private System.Windows.Forms.Label lbTimeStamp;
    }
}
