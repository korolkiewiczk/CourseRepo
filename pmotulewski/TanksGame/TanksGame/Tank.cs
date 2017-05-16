using System;

namespace TanksGame
{
    internal class Tank : MoveableGameObject
    {
        public event Action FireEvent;

        public Tank(Position position, Dimension dimension) : base(position, dimension)
        {
        }

        public void Move(Direction direction)
        {
            if (direction == Direction.LEFT)
            {
                Position = Position.Shift(-1, 0);
            }
            if (direction == Direction.RIGHT)
            {
                Position = Position.Shift(1, 0);
            }
        }

        public void Fire()
        {
            OnFireEvent();
            Move(Direction.LEFT);
        }

        protected virtual void OnFireEvent()
        {
            FireEvent?.Invoke();
        }
    }
}