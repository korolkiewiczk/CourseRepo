using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanksGame
{
    public partial class Form1 : Form
    {
        private const int TankPositionY = 45;
        private const int TankWidth = 40;
        private const int TankHeight = 25;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var form = (Form)sender;
            e.Graphics.DrawLine(new Pen(Color.Black),
                x1: 0, y1: form.Height - 20,
                x2: form.Width, y2: form.Height - 20);

            var xPosition = 40;
            var yPosition = form.Height - TankPositionY;
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), 
               xPosition, yPosition,
               TankWidth, TankHeight);

            e.Graphics.DrawLine(new Pen(Color.Red), new Point(xPosition+TankWidth/2,yPosition), GetPosiotionFromAngle(xPosition + TankWidth / 2, yPosition,30,30) );
           

        }

        private Point GetPosiotionFromAngle(int x1, int y1, int angle, int len)
        {
            int width = (int)Math.Round(len * Math.Cos(-angle * Math.PI / 180));
            int height = (int)Math.Round(len * Math.Sin(-angle * Math.PI / 180));

            return new Point(x1+width, y1+height);
        }

    }
}
