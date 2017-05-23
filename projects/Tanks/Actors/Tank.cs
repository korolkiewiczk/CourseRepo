﻿using System;
using Tanks.Utlis;

namespace Tanks.Actors
{
    class Tank : MoveableGameObject
    {
        private Barrel _barrel;
        private double _angle;
        private double _power=10;

        public event Action FireEvent;

        public Tank(Vector2D position, Dimension dimension, Texture texture) : base(position, dimension, texture, Shape.FillRect)
        {
            _barrel = new Barrel(new Vector2D(position.X + dimension.Width / 2, position.Y),
                new Dimension(dimension.Width / 2, 0), texture);
            AddChild(_barrel);

            SetAngle(Math.PI / 3);
        }

        public void MoveAngle(Direction direction)
        {
            if (direction == Direction.Up)
            {
                SetAngle(_angle + Math.PI / 20);
            }

            if (direction == Direction.Down)
            {
                SetAngle(_angle - Math.PI / 20);
            }
        }

        public void ChangePower(Direction direction)
        {
            if (direction == Direction.Up)
            {
                SetPower(Math.Min(50, _power + 0.5));
            }

            if (direction == Direction.Down)
            {
                SetPower(Math.Max(1, _power - 0.5));
            }
        }

        private void SetAngle(double angle)
        {
            _angle = angle;
            _barrel.SetRotation(-_angle);
        }

        private void SetPower(double power)
        {
            _power = power;
        }
        public void Move(Direction direction)
        {
            if (direction == Direction.Left)
            {
                Velocity = new Vector2D(-0.1, 0);
            }
            if (direction == Direction.Right)
            {
                Velocity = new Vector2D(0.1, 0);
            }

            _barrel.Synchronize(this);
        }

        public override void Update(double tick)
        {
            base.Update(tick);
            Velocity = new Vector2D(0, 0);
            _barrel.Synchronize(this);
        }

        public void Fire()
        {
            Rocket _rocket = new Rocket(this._barrel.Position, new Dimension(0.01, 0.01), this.Texture, 
                ((Vector2D)_barrel.Dimension)*_power, new Vector2D(0,1));

            
            AddChild(_rocket);


            //OnFireEvent();
        }

        protected virtual void OnFireEvent()
        {
            FireEvent?.Invoke();
        }
    }
}
