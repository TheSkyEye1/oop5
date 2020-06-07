using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public List<Bitmap> galery = new List<Bitmap>();
        public List<Bitmap> galeryc = new List<Bitmap>();
        public Form1()
        {
            InitializeComponent();
            galery.Add(Properties.Resources.i1);
            galery.Add(Properties.Resources.i2);
            galery.Add(Properties.Resources.i3);

            gal.pictures = galery;
            galc.pictures = galery;
        }
    }
}
