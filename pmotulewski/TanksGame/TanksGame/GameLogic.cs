using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanksGame
{
    class GameLogic
    {
        private List<Tank> _tanks;
        private Rocket _rocket;
        private Board _board;
        private StatusPanel _statusPanel;
        private ITank activeTank;

        private State _state;

        public void Initialize()
        {
            _tanks=new List<Tank>();
            var tank1 = new Tank(new Position(10,10), new Dimension(40,30));

            tank1.FireEvent += Tank1_FireEvent;

            _tanks.Add(tank1);

        }

        private void Tank1_FireEvent()
        {
            _rocket.Launch();
        }

        public void Draw(Graphics g)
        {
            _board.Draw();
            DrawTanks(g);

            switch (_state)
            {
                case State.Aim:
                    _statusPanel.DrawAimValues(activeTank);
                    break;
                case State.Shoot:
                    break;
                case State.Hit:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void DrawTanks(Graphics g)
        {
            foreach (var tank in _tanks)
            {
                //tank.Draw(g);
            }
        }

        public void Tick()
        {
            
        }

        public void KeyPress(char c)
        {
            if (c == ' ')
            {
                _tanks[0].Fire();
            }
        }
    }
}
