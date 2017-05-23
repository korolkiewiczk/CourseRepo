namespace Tanks.Utlis
{
    internal class Dimension
    {
        public double Width { get; }
        public double Height { get; }

        public Dimension(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public static implicit operator Dimension(Vector2D vector)
        {
            return new Dimension(vector.X, vector.Y);
        }
    }
}