using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Utlis;

namespace Tanks.Drawing
{
    class StatusDrawer : Drawer
    {
        public StatusDrawer(Dimension windowSize) : base(windowSize)
        {
        }

        public void DrawStatus(Graphics graphics, TankStatus status)
        {
            var pos = ToAbsolutePosition(new Vector2D(0.05, 0.05));
            graphics.DrawString(status.ToString(), new Font(FontFamily.GenericSansSerif, 10.0f),
                new SolidBrush(Color.Black), new PointF((float) pos.X, (float) pos.Y));
        }
    }
}
