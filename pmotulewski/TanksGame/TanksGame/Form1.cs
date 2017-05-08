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
        private int yPosition;
        private int tempX = 40;
        private int tempA = 500;
        private int tempAng = 45;
        private int power = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var form = (Form)sender;
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawLine(new Pen(Color.Black),
                x1: 0, y1: form.ClientSize.Height - 20,
                x2: form.Width, y2: form.ClientSize.Height - 20);

            var xPosition = 40;
            yPosition = form.ClientSize.Height - TankPositionY;


            DrawTank(tempX, 40, tempAng, 10, Color.Green, e);

            DrawTank(300, 40, 120, 10, Color.Red, e);
            //DrawTank(tempA, 40, 90, 10, Color.Blue, e);
            //DrawTank(tempX, 40, 90, 10, Color.Blue, e);

 

            int[] xh = drawFire(new Point(0, 0), tempAng, power);


            Point[] points = new Point[] { new Point(tempX+20, yPosition), new Point(tempX+20 + (xh[0]/2) , yPosition - xh[1]), new Point(tempX+20 + xh[0], yPosition) };
            String s = "Length: "+ xh[0] + " Height: "+xh[1]+ " angle: "+xh[2];

            e.Graphics.DrawCurve(new Pen(Color.Red), points);
            e.Graphics.DrawString(s, new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(Color.Black), new PointF(0, 0));

        }

        

        public void DrawTank(int positionX, int size, int angle, int power, Color color, PaintEventArgs e) {
            e.Graphics.FillRectangle(new SolidBrush(color), positionX, yPosition, size, TankHeight);
            e.Graphics.DrawLine(new Pen(color), new Point(positionX + size / 2, yPosition), GetPosiotionFromAngle(positionX + size / 2, yPosition, angle, 30));


        }




        private int[] drawFire(Point startPoint, int angle, int power)
        {
            int h;
            int distance;
            double g = 1;
            double v = power;
            int x = 0;

            h = (int) Math.Round((v * v * sinFromAngle(-angle) * sinFromAngle(-angle) / 2 * g));
            x = (int) Math.Round(v * v * sinFromAngle(2 * -angle) / g);

            int[] temp = {x, h, -angle };

            System.Console.WriteLine(temp);
            return temp;



        }

        private double sinFromAngle(double angle)
        {
            return Math.Sin(getRadianFromAngle(angle));
        }

        private double getRadianFromAngle(double angle)
        {
            return -angle * Math.PI / 180.0;
        }


        private Point GetPosiotionFromAngle(int x1, int y1, int angle, int len)
        {
            int width = (int)Math.Round(len * Math.Cos(-angle * Math.PI / 180));
            int height = (int)Math.Round(len * Math.Sin(-angle * Math.PI / 180));

            return new Point(x1+width, y1+height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();         
   
            
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'l')
            {
                tempX+=2;
            }

            if (e.KeyChar == 'k')
            {
                tempX-=2;
            }


            if (e.KeyChar == 'w')
            {
                power += 1;
            }

            if (e.KeyChar == 'q')
            {
                power -= 1;
            }



            if (e.KeyChar == 'a')
            {
                tempAng += 1;
            }

            if (e.KeyChar == 's')
            {
                tempAng -= 1;
            }






        }
    }
}
