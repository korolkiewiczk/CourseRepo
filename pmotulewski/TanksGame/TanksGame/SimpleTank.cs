using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanksGame
{
    class SimpleTank : ITank
    {
        private int positionX;
        private int positionY;
        private int size;
        private Color color;
        private int power;
        private int angle;
        private int tankHeight = 25;


        public SimpleTank(int positionX, int size, Color color)
        {
            this.positionX = positionX;
            this.size = size;
            this.color = color;
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(color), positionX, positionY, size, tankHeight);
            g.DrawLine(new Pen(color), new Point(positionX + size / 2, positionY), GetPosiotionFromAngle(positionX + size / 2, positionY, angle, 30));
            
        }

        public void ChangeAngleAndPower(Direction power, Direction angle)
        {
            throw new NotImplementedException();
        }

        public void Fire()
        {
            throw new NotImplementedException();
        }

        public void Move(Direction direction)
        {
            throw new NotImplementedException();
        }



        private double sinFromAngle(int angle)
        {
            return Math.Sin(getRadianFromAngle(angle));
        }

        private int getRadianFromAngle(int angle)
        {
            return (int)Math.Round(-angle * Math.PI / 180);
        }


        private Point GetPosiotionFromAngle(int x1, int y1, int angle, int len)
        {
            int width = (int)Math.Round(len * Math.Cos(-angle * Math.PI / 180));
            int height = (int)Math.Round(len * Math.Sin(-angle * Math.PI / 180));

            return new Point(x1 + width, y1 + height);
        }


    }
}
