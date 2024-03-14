namespace BaiThucHanh1
{
    partial class Form1
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
            this.panelUsers = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMultiUsers = new System.Windows.Forms.Panel();
            this.userControlUser1 = new BaiThucHanh1.UserControlUser();
            this.panelUsers.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelMultiUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUsers
            // 
            this.panelUsers.Controls.Add(this.userControlUser1);
            this.panelUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsers.Location = new System.Drawing.Point(0, 0);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(370, 197);
            this.panelUsers.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.panelMultiUsers, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1075, 558);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelMultiUsers
            // 
            this.panelMultiUsers.Controls.Add(this.panelUsers);
            this.panelMultiUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMultiUsers.Location = new System.Drawing.Point(3, 3);
            this.panelMultiUsers.Name = "panelMultiUsers";
            this.panelMultiUsers.Size = new System.Drawing.Size(370, 552);
            this.panelMultiUsers.TabIndex = 1;
            // 
            // userControlUser1
            // 
            this.userControlUser1.Location = new System.Drawing.Point(0, 3);
            this.userControlUser1.Name = "userControlUser1";
            this.userControlUser1.Size = new System.Drawing.Size(198, 76);
            this.userControlUser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 558);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelUsers.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelMultiUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelMultiUsers;
        private UserControlUser userControlUser1;
    }
}

