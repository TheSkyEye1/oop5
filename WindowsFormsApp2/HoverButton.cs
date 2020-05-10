using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class HoverButton : Button
    {
        protected StringFormat strinf;
        protected SolidBrush brush;
        protected Font font;
        public HoverButton() : base()
        {
            ForeColor = Color.LightBlue;
            font = new Font("Times New Roman",
                20,
                FontStyle.Bold,
                GraphicsUnit.Point,
                0);
            brush = new SolidBrush(ForeColor);
        }
    }
}
