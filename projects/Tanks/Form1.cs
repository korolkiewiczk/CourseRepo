using System;
using System.Windows.Forms;
using Tanks.Drawing;
using Tanks.Logic;
using Tanks.Utlis;

namespace Tanks
{
    public partial class Form1 : Form
    {
        private TanksGame _tanksGame;

        public Form1()
        {
            InitializeComponent();

            SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);

            Timer gameTimer = new Timer();
            gameTimer.Interval = 30;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            Paint += Form1_Paint;

            KeyDown += Form1_KeyDown;
            var scrDimension = new Dimension(ClientSize.Width, ClientSize.Height);
            _tanksGame = new TanksGame(new GameObjectDrawer(scrDimension), new BoardDrawer(scrDimension),
                new StatusDrawer(scrDimension));
            _tanksGame.Initialize();
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            _tanksGame.KeyPress((char)e.KeyValue);
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            _tanksGame.Draw(e.Graphics);
        }

        void GameTimer_Tick(object sender, EventArgs e)
        {
            _tanksGame.Tick();
            Invalidate();
        }
    }
}
