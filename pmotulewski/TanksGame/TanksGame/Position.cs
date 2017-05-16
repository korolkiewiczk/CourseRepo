namespace TanksGame
{
    public class Position
    {
        public double X { get; }
        public double Y { get; }

        public Position(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Position Shift(double dx, double dy)
        {
            return new Position(X + dx, Y + dy);
        }
    }
}