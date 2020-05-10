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
        private Bitmap picture = new Bitmap(Properties.Resources.i1);

        private int i = 1;

        private string name = "";

        protected override void OnMouseEnter(EventArgs e)
        {
            

            if(i == 1)
            {
                name = "picture 1";
            }
            if (i == 2)
            {
                name = "picture 2";
            }
            if (i == 3)
            {
                name = "picture 3";
            }
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            name = "";
            base.OnMouseLeave(e);
        }

        protected override void OnPaint(PaintEventArgs paint)
        {
            if (i == 1)
            {
                picture = new Bitmap(Properties.Resources.i1);
                if (name == "")
                {
                    name = "";
                }
                else
                {
                    name = "picture 1";
                }
            }
            if (i == 2)
            {
                picture = new Bitmap(Properties.Resources.i2);
                if (name == "")
                {
                    name = "";
                }
                else
                {
                    name = "picture 2";
                }
            }
            if (i == 3)
            {
                picture = new Bitmap(Properties.Resources.i3);
                if (name == "")
                {
                    name = "";
                }
                else
                {
                    name = "picture 3";
                }
            }

            paint.Graphics.DrawImage(picture, 0, 0);

            strinf = new StringFormat();
            strinf.Alignment = StringAlignment.Center;
            strinf.LineAlignment = StringAlignment.Center;

            paint.Graphics.DrawString(name, font, brush, ClientRectangle, strinf);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            i++;
            if (i > 3)
                i = 1;
        }
    }
}
