using System;
using System.Collections.Generic;
using Tanks.Utlis;

namespace Tanks.Actors
{
    class Board
    {
        private List<Vector2D> _edgesPositions;

        public Board()
        {
            _edgesPositions = new List<Vector2D>();
            _edgesPositions.Add(new Vector2D(0, 0.9));
            _edgesPositions.Add(new Vector2D(1, 0.9));
        }

        public void IterateThroughPositions(Action<Vector2D, Vector2D> action)
        {
            for (int i = 1; i < _edgesPositions.Count; i++)
            {
                action( _edgesPositions[i - 1], _edgesPositions[i]);
            }
        }
    }
}
