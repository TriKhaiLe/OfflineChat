namespace BaiThucHanh1.UserControls
{
    partial class IconBlock
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
            this.lbTimeStamp = new System.Windows.Forms.Label();
            this.ptbIcon = new BaiThucHanh1.UserControls.CircularPicturebox();
            this.ptbAvatar = new BaiThucHanh1.UserControls.CircularPicturebox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTimeStamp
            // 
            this.lbTimeStamp.AutoSize = true;
            this.lbTimeStamp.Location = new System.Drawing.Point(769, 80);
            this.lbTimeStamp.Name = "lbTimeStamp";
            this.lbTimeStamp.Size = new System.Drawing.Size(78, 16);
            this.lbTimeStamp.TabIndex = 3;
            this.lbTimeStamp.Text = "24:24:24 AM";
            // 
            // ptbIcon
            // 
            this.ptbIcon.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ptbIcon.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ptbIcon.BorderColor2 = System.Drawing.Color.HotPink;
            this.ptbIcon.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ptbIcon.BorderSize = 0;
            this.ptbIcon.GradientAngle = 50F;
            this.ptbIcon.Location = new System.Drawing.Point(91, 3);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(73, 73);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIcon.TabIndex = 4;
            this.ptbIcon.TabStop = false;
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
            this.ptbAvatar.TabIndex = 1;
            this.ptbAvatar.TabStop = false;
            // 
            // IconBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptbIcon);
            this.Controls.Add(this.lbTimeStamp);
            this.Controls.Add(this.ptbAvatar);
            this.Name = "IconBlock";
            this.Size = new System.Drawing.Size(850, 105);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPicturebox ptbAvatar;
        private System.Windows.Forms.Label lbTimeStamp;
        private CircularPicturebox ptbIcon;
    }
}
