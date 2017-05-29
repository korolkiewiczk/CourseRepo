using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Actors;
using Tanks.Drawing;
using Tanks.Utlis;

namespace Tanks.Logic
{
    class TanksGame
    {
        private List<Tank> _tanks;
        private Rocket _rocket;
        private Board _board;

        private State _state;
        private readonly GameObjectDrawer _gameObjectDrawer;
        private readonly BoardDrawer _boardDrawer;
        private readonly StatusDrawer _statusDrawer;

        private readonly Stopwatch _stopwatch = new Stopwatch();

        public TanksGame(GameObjectDrawer gameObjectDrawer, BoardDrawer boardDrawer, StatusDrawer statusDrawer)
        {
            _gameObjectDrawer = gameObjectDrawer;
            _boardDrawer = boardDrawer;
            _statusDrawer = statusDrawer;
        }

        public void Initialize()
        {
            _tanks = new List<Tank>();
            var tank1 = new Tank(new Vector2D(0.1, 0.8), new Dimension(0.15, 0.1), Texture.Green);
            var tank2 = new Tank(new Vector2D(0.8, 0.8), new Dimension(0.15, 0.1), Texture.Red);

            tank1.FireEvent += Tank1_FireEvent;

            _tanks.Add(tank1);
            _tanks.Add(tank2);

            _board = new Board();
        }

        private void Tank1_FireEvent()
        {
            _rocket.Launch();
        }

        public void Draw(Graphics g)
        {
            DrawTanks(g);
            DrawStatus(g);

            _boardDrawer.Draw(g, _board);

            switch (_state)
            {
                case State.Aim:
                    break;
                case State.Shoot:
                    break;
                case State.Hit:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Tick()
        {
            if (!_stopwatch.IsRunning)
            {
                _stopwatch.Start();
                return;
            }


            var tick = _stopwatch.ElapsedMilliseconds;

            foreach (var tank in _tanks)
            {
                tank.Update((double)tick / 1000);
            }

            _stopwatch.Restart();
        }

        public void KeyPress(char c)
        {
            c = Char.ToLower(c);
            var tank = _tanks[0];
            if (c == 's')
            {
                tank.Move(Direction.Right);
            }
            if (c == 'a')
            {
                tank.Move(Direction.Left);
            }

            if (c == 'e')
            {
                tank.ChangeAngle(Direction.Up);
            }

            if (c == 'd')
            {
                tank.ChangeAngle(Direction.Down);
            }

            if (c == 'x')
            {
                tank.ChangePower(Direction.Up);
            }

            if (c == 'z')
            {
                tank.ChangePower(Direction.Down);
            }

            if (c == ' ')
            {
                tank.Fire();
            }
        }

        private void DrawStatus(Graphics graphics)
        {
            var tank = _tanks[0];
            _statusDrawer.DrawStatus(graphics, tank.Status);
        }

        private void DrawTanks(Graphics g)
        {
            foreach (var tank in _tanks)
            {
                _gameObjectDrawer.Draw(g, tank);
            }
        }
    }
}
