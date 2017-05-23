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
    class GameObjectDrawer : Drawer
    {
        public GameObjectDrawer(Dimension windowSize) : base(windowSize)
        {
        }

        public void Draw(Graphics graphics, GameObject gameObject)
        {
            switch (gameObject.Shape)
            {
                case Shape.FillRect:
                    graphics.FillRectangle(GetBrush(gameObject), ConvertToRectangle(gameObject));
                    break;
                case Shape.FillEllipse:
                    graphics.FillEllipse(GetBrush(gameObject), ConvertToRectangle(gameObject));
                    break;
                case Shape.Line:
                    {
                        var rect = ConvertToRectangle(gameObject);
                        graphics.DrawLine(GetPen(gameObject), rect.X, rect.Y, rect.X + rect.Width, rect.Y + rect.Height);
                    }

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            foreach (var moveableGameObject in gameObject.Children)
            {
                Draw(graphics, moveableGameObject);
            }
        }

        private static Color GetColor(GameObject gameObject)
        {
            switch (gameObject.Texture)
            {
                case Texture.Red:
                    return Color.Red;
                case Texture.Green:
                    return Color.Green;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static Pen GetPen(GameObject gameObject)
        {
            return new Pen(GetColor(gameObject));
        }

        private static Brush GetBrush(GameObject gameObject)
        {
            return new SolidBrush(GetColor(gameObject));
        }

        private Rectangle ConvertToRectangle(GameObject gameObject)
        {
            var pos = ToAbsolutePosition(gameObject.Position);
            var dim = ToAbsolutePosition(gameObject.Dimension);

            return new Rectangle((int) pos.X, (int) pos.Y, (int) dim.X, (int) dim.Y);
        }
    }
}
