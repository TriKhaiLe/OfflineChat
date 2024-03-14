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
    public class RoundedTextBox : TextBox
    {
        private Color borderColor = ColorTranslator.FromHtml("#dddfe2"); // Chuyển đổi mã màu hex sang Color
        private int borderRadius = 8;
        private int padding = 5; // Padding xung quanh nội dung của TextBox
        private int textBoxHeight = 30; // Chiều cao của TextBox

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); }
        }

        public int Padding
        {
            get { return padding; }
            set { padding = value; Invalidate(); }
        }

        public int TextBoxHeight
        {
            get { return textBoxHeight; }
            set { textBoxHeight = value; Height = value; Invalidate(); }
        }

        public RoundedTextBox()
        {
            this.BorderStyle = BorderStyle.None;
            this.Height = textBoxHeight;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen borderPen = new Pen(borderColor))
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90);
                    path.AddArc(this.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90);
                    path.AddArc(this.Width - borderRadius * 2, this.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
                    path.AddArc(0, this.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
                    path.CloseFigure();

                    g.DrawPath(borderPen, path);
                }
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate(); // Yêu cầu vẽ lại control khi text thay đổi
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = textBoxHeight;
        }

    }
}
