using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
{
    public partial class Form1 : Form
    {
        int userLocation = 3;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("ava", typeof(Image));
            dt.Columns.Add("online", typeof(Image));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("text", typeof(string));
            dt.Rows.Add(1, global::BaiThucHanh1.Properties.Resources.ava, global::BaiThucHanh1.Properties.Resources.on, "Mạnh Nghĩa", "Online");
            dt.Rows.Add(2, global::BaiThucHanh1.Properties.Resources.ava01, global::BaiThucHanh1.Properties.Resources.on, "Huỳnh Trâm", "Chào ngày mới!");
            dt.Rows.Add(3, global::BaiThucHanh1.Properties.Resources.ava02, global::BaiThucHanh1.Properties.Resources.off, "Tùng Dương", "Offline");
            dt.Rows.Add(4, global::BaiThucHanh1.Properties.Resources.ava03, global::BaiThucHanh1.Properties.Resources.on, "Minh Lan", "Rộn ràng");
            dt.Rows.Add(5, global::BaiThucHanh1.Properties.Resources.ava04, global::BaiThucHanh1.Properties.Resources.on, "Bảo Hưng", "Vừa xong");
            dt.Rows.Add(6, global::BaiThucHanh1.Properties.Resources.ava05, global::BaiThucHanh1.Properties.Resources.off, "Tú Ngọc", "Offline");
            
            for (int i = 0; i <= 5; i++)
            {
                LoadUser(i);
            }
        }

        void LoadUser(int id)
        {
            UserControlUser userControl = new UserControlUser();
            userControl.LoadData((int)dt.Rows[id]["ID"], 
                (Image)(dt.Rows[id]["ava"]), 
                (Image)(dt.Rows[id]["online"]), 
                (string)(dt.Rows[id]["name"]).ToString(), 
                (string)(dt.Rows[id]["text"]).ToString());
            this.panelMultiUsers.Controls.Add(userControl);
            userControl.Location = new Point(3, userLocation);
            userLocation += 100;
        }
    }
}
