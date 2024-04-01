namespace BaiThucHanh1
{
    partial class SettingsWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtLight = new System.Windows.Forms.RadioButton();
            this.rbtDark = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtViet = new System.Windows.Forms.RadioButton();
            this.rbtEng = new System.Windows.Forms.RadioButton();
            this.btnOk = new BaiThucHanh1.UserControls.RoundedButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.716981F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.16981F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.716981F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.54717F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.84906F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 207);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.rbtDark);
            this.panel3.Controls.Add(this.rbtLight);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 174);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dark mode settings";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 141);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtViet);
            this.panel4.Controls.Add(this.rbtEng);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(476, 109);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Language";
            // 
            // rbtLight
            // 
            this.rbtLight.AutoSize = true;
            this.rbtLight.Location = new System.Drawing.Point(87, 47);
            this.rbtLight.Name = "rbtLight";
            this.rbtLight.Size = new System.Drawing.Size(94, 20);
            this.rbtLight.TabIndex = 0;
            this.rbtLight.TabStop = true;
            this.rbtLight.Text = "Light mode";
            this.rbtLight.UseVisualStyleBackColor = true;
            this.rbtLight.CheckedChanged += new System.EventHandler(this.rbtLight_CheckedChanged);
            // 
            // rbtDark
            // 
            this.rbtDark.AutoSize = true;
            this.rbtDark.Location = new System.Drawing.Point(87, 102);
            this.rbtDark.Name = "rbtDark";
            this.rbtDark.Size = new System.Drawing.Size(95, 20);
            this.rbtDark.TabIndex = 1;
            this.rbtDark.TabStop = true;
            this.rbtDark.Text = "Dark mode";
            this.rbtDark.UseVisualStyleBackColor = true;
            this.rbtDark.CheckedChanged += new System.EventHandler(this.rbtDark_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(249, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 47);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(249, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 47);
            this.label4.TabIndex = 3;
            // 
            // rbtViet
            // 
            this.rbtViet.AutoSize = true;
            this.rbtViet.Location = new System.Drawing.Point(87, 71);
            this.rbtViet.Name = "rbtViet";
            this.rbtViet.Size = new System.Drawing.Size(155, 20);
            this.rbtViet.TabIndex = 3;
            this.rbtViet.TabStop = true;
            this.rbtViet.Text = "Tiếng Việt (Việt Nam)";
            this.rbtViet.UseVisualStyleBackColor = true;
            this.rbtViet.CheckedChanged += new System.EventHandler(this.rbtViet_CheckedChanged);
            // 
            // rbtEng
            // 
            this.rbtEng.AutoSize = true;
            this.rbtEng.Location = new System.Drawing.Point(87, 16);
            this.rbtEng.Name = "rbtEng";
            this.rbtEng.Size = new System.Drawing.Size(163, 20);
            this.rbtEng.TabIndex = 2;
            this.rbtEng.TabStop = true;
            this.rbtEng.Text = "English (United States)";
            this.rbtEng.UseVisualStyleBackColor = true;
            this.rbtEng.CheckedChanged += new System.EventHandler(this.rbtEng_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOk.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOk.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOk.BorderRadius = 8;
            this.btnOk.BorderSize = 0;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(367, 405);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 45);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsWindow";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtDark;
        private System.Windows.Forms.RadioButton rbtLight;
        private System.Windows.Forms.RadioButton rbtViet;
        private System.Windows.Forms.RadioButton rbtEng;
        private UserControls.RoundedButton btnOk;
    }
}