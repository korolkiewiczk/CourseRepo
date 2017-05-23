using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Actors;
using Tanks.Utlis;

namespace Tanks.Drawing
{
    class BoardDrawer : Drawer
    {
        public BoardDrawer(Dimension windowSize) : base(windowSize)
        {
        }

        public void Draw(Graphics graphics, Board board)
        {
            board.IterateThroughPositions((a, b) =>
            {
                var posa = ToAbsolutePosition(a);
                var posb = ToAbsolutePosition(b);
                graphics.DrawLine(GetPen(), (int) posa.X, (int)posa.Y, (int)posb.X, (int)posb.Y);
            });
        }

        private static Pen GetPen()
        {
            return new Pen(Color.Black);
        }
    }
}
