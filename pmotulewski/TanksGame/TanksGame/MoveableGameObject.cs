namespace TanksGame
{
    public class MoveableGameObject
    {
        public Position Position { get; protected set; }
        public Dimension Dimension { get; protected set; }

        public MoveableGameObject(Position position, Dimension dimension)
        {
            Position = position;
            Dimension = dimension;
        }
    }
}