using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1.UserControls
{
    public class RoundedPictureBox : PictureBox
    {
        public int CornerRadius { get; set; } = 10; // Độ cong của góc, có thể thay đổi tùy ý

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, CornerRadius * 2, CornerRadius * 2, 180, 90); // Góc trên bên trái
            path.AddArc(Width - CornerRadius * 2, 0, CornerRadius * 2, CornerRadius * 2, 270, 90); // Góc trên bên phải
            path.AddArc(Width - CornerRadius * 2, Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 0, 90); // Góc dưới bên phải
            path.AddArc(0, Height - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 90, 90); // Góc dưới bên trái
            path.CloseAllFigures();

            this.Region = new Region(path);
        }
    }

}
