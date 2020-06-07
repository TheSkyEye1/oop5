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
            brush = new SolidBrush(Color.DarkBlue);
            font = new Font("Times New Roman",
                25,
                FontStyle.Bold,
                GraphicsUnit.Point,
                0);
        }
    }
}
