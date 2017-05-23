using Tanks.Utlis;

namespace Tanks.Actors
{
    class Rocket : MoveableGameObject
    {
        

        public Rocket(Vector2D position, Dimension dimension, Texture texture,
            Vector2D velocity, Vector2D acceleration) : base(position, dimension, texture, Shape.FillEllipse)
        {
            Velocity = velocity;
            Acceleration = acceleration;
        }

        public void Launch()
        {
        }
    }
}