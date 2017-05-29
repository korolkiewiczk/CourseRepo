using System;
using Tanks.Utlis;

namespace Tanks.Actors
{
    class Tank : MoveableGameObject
    {
        private const double MaxPower = 25;
        private const int MaxFuel = 100;

        private readonly Barrel _barrel;
        private double _angle;
        private double _power = 10;
        private int _fuel = 100;

        public TankStatus Status => new TankStatus(_angle, _power, _fuel, MaxPower, MaxFuel);

        public Tank(Vector2D position, Dimension dimension, Texture texture) : base(position, dimension, texture, Shape.FillRect)
        {
            _barrel = new Barrel(new Vector2D(position.X + dimension.Width / 2, position.Y),
                new Dimension(dimension.Width / 2, 0), texture);
            AddChild(_barrel);

            SetAngle(Math.PI / 3);
        }

        public void ChangeAngle(Direction direction)
        {
            if (direction == Direction.Up)
            {
                SetAngle(_angle + Math.PI / 60);
            }

            if (direction == Direction.Down)
            {
                SetAngle(_angle - Math.PI / 60);
            }
        }

        public void ChangePower(Direction direction)
        {
            if (direction == Direction.Up)
            {
                SetPower(Math.Min(MaxPower, _power + MaxPower / 50));
            }

            if (direction == Direction.Down)
            {
                SetPower(Math.Max(1, _power - MaxPower / 50));
            }
        }

        private void SetAngle(double angle)
        {
            _angle = Math.Min(Math.PI, Math.Max(0, angle));
            _barrel.SetRotation(-_angle);
        }

        private void SetPower(double power)
        {
            _power = power;
        }

        public void Move(Direction direction)
        {
            if (_fuel > 0)
            {
                if (direction == Direction.Left)
                {
                    Velocity = new Vector2D(-0.1, 0);
                    DecreaseFuelCapacity();
                }
                if (direction == Direction.Right)
                {
                    Velocity = new Vector2D(0.1, 0);
                    DecreaseFuelCapacity();
                }
            }
            _barrel.Synchronize(this);
        }

        private void DecreaseFuelCapacity()
        {
            _fuel = Math.Max(0, _fuel - 1);
        }

        public override void Update(double tick)
        {
            base.Update(tick);
            Velocity = new Vector2D(0, 0);
            _barrel.Synchronize(this);
        }

        public void Fire()
        {
            Rocket rocket = new Rocket(_barrel.Position, new Dimension(0.01, 0.01), Texture,
                ((Vector2D)_barrel.Dimension) * _power, new Vector2D(0, 1));


            AddChild(rocket);
        }
    }
}
