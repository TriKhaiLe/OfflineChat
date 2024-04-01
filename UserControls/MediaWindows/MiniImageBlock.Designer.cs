namespace BaiThucHanh1.UserControls.MediaWindows
{
    partial class MiniImageBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniImageBlock));
            this.lbTimeStamp = new System.Windows.Forms.Label();
            this.ptbImage = new BaiThucHanh1.UserControls.RoundedPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTimeStamp
            // 
            this.lbTimeStamp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTimeStamp.Location = new System.Drawing.Point(0, 175);
            this.lbTimeStamp.Name = "lbTimeStamp";
            this.lbTimeStamp.Size = new System.Drawing.Size(200, 25);
            this.lbTimeStamp.TabIndex = 1;
            this.lbTimeStamp.Text = "...";
            this.lbTimeStamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbImage
            // 
            this.ptbImage.BorderColor = System.Drawing.Color.Cyan;
            this.ptbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImage.BorderWidth = 3;
            this.ptbImage.CornerRadius = 10;
            this.ptbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbImage.Image = ((System.Drawing.Image)(resources.GetObject("ptbImage.Image")));
            this.ptbImage.Location = new System.Drawing.Point(0, 0);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(200, 175);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImage.TabIndex = 4;
            this.ptbImage.TabStop = false;
            // 
            // MiniImageBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.lbTimeStamp);
            this.Name = "MiniImageBlock";
            this.Size = new System.Drawing.Size(200, 200);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimeStamp;
        private RoundedPictureBox ptbImage;
    }
}
