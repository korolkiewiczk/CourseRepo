using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TowerOfHanoi.Logic;

namespace TowerOfHanoi.WindowSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw=new BackgroundWorker();
            bw.DoWork += (s, ea) =>
            {
                var algorithm = new Logic.Algorithm((int)numberOfKrazki.Value + 1, new Display(this));
                algorithm.Solve();
            };
            
            bw.RunWorkerAsync();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (_currentState == null) return;
            var towerA = _currentState.TowerA;
            var towerB = _currentState.TowerB;
            var towerC = _currentState.TowerC;
            DrawTower(e, towerA, 0);
            DrawTower(e, towerB, 100);
            DrawTower(e, towerC, 200);
        }

        private void DrawTower(PaintEventArgs e, Stack<int> tower, int x0)
        {
            int y = 100 - tower.Count * 10;
            foreach (var krazek in tower)
            {
                int x = x0 + (int) numberOfKrazki.Value * 10 - krazek * 10 / 2;
                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(x, y, krazek * 10, 10));
                y += 10;
            }
        }

        public void RedrawCanvas(State state)
        {
            _currentState = state;
            canvas.Refresh();
        }

        private State _currentState;
        public int Timeout => (int)interval.Value;
    }

    internal class Display : IDisplay
    {
        private readonly Form1 _form;

        public Display(Form1 form)
        {
            _form = form;
        }

        void IDisplay.Display(State state)
        {
            _form.Invoke(new Action(() => _form.RedrawCanvas(state)));
            
            Thread.Sleep(_form.Timeout);
        }
    }
}
