namespace BaiThucHanh1.UserControls
{
    partial class UserDisplay
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.ptbStatus = new System.Windows.Forms.PictureBox();
            this.ptbAvatar = new BaiThucHanh1.UserControls.CircularPicturebox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(96, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(16, 16);
            this.lbName.TabIndex = 17;
            this.lbName.Text = "...";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(132, 44);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(16, 16);
            this.lbStatus.TabIndex = 19;
            this.lbStatus.Text = "...";
            // 
            // ptbStatus
            // 
            this.ptbStatus.Location = new System.Drawing.Point(86, 37);
            this.ptbStatus.Name = "ptbStatus";
            this.ptbStatus.Size = new System.Drawing.Size(30, 30);
            this.ptbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbStatus.TabIndex = 18;
            this.ptbStatus.TabStop = false;
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
            this.ptbAvatar.TabIndex = 20;
            this.ptbAvatar.TabStop = false;
            // 
            // UserDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptbAvatar);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.ptbStatus);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.Name = "UserDisplay";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Size = new System.Drawing.Size(290, 70);
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox ptbStatus;
        private System.Windows.Forms.Label lbStatus;
        private CircularPicturebox ptbAvatar;
    }
}
