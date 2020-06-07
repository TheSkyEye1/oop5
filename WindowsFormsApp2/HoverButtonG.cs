using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class HoverButtonG : HoverButton
    {
        public List<Bitmap> pictures = new List<Bitmap>();
        private int i = 0;
        private string name = "";

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            name = "image " + Convert.ToString(i + 1);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            name = "";
        }

        protected override void OnPaint(PaintEventArgs paint)
        {
            paint.Graphics.DrawImage(pictures[i], 0, 0);
            strinf = new StringFormat();
            strinf.Alignment = StringAlignment.Center;
            strinf.LineAlignment = StringAlignment.Center;
            paint.Graphics.DrawString(name, font, brush, ClientRectangle, strinf);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            i++;
            if (i > pictures.Count-1)
                i = 0;
        }
    }
}
