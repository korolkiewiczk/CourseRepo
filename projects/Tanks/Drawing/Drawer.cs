using System;
using Tanks.Utlis;

namespace Tanks.Drawing
{
    abstract class Drawer
    {
        protected readonly Dimension _windowSize;

        public Drawer(Dimension windowSize)
        {
            _windowSize = windowSize;
        }

        protected Vector2D ToAbsolutePosition(Vector2D vec)
        {
            return new Vector2D(Math.Round(vec.X * _windowSize.Width),
                Math.Round(vec.Y * _windowSize.Height));
        }
    }
}
