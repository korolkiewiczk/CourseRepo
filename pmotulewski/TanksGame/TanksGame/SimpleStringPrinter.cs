using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanksGame
{
    class SimpleStringPrinter : StringPrinterInterface
    {
        private PaintEventArgs e;

        public SimpleStringPrinter(PaintEventArgs e)
        {
            this.e = e;

        }

        void StringPrinterInterface.simpleLoging(string s)
        {
            e.Graphics.DrawString(s, new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(Color.Black), new PointF(0, 0));
        }
    }
}
