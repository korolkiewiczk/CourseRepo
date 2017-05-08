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
        private List<ITank> _tanks;
        private Rocket _rocket;
        private Board _board;
        private StatusPanel _statusPanel;
        private ITank activeTank;

        private State _state;

        public void Initialize()
        {
            
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
                tank.Draw(g);
            }
        }

        public void Tick()
        {
            
        }
    }
}
