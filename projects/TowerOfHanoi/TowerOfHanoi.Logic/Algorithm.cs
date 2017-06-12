using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Logic
{
    public class Algorithm
    {
        private int _n;
        private readonly IDisplay _display;
        private State _state;

        public Algorithm(int n, IDisplay display)
        {
            _n = n;
            _display = display;
            _state = new State(n);
        }

        public void Solve()
        {
            _Solve(_n, _state.TowerA, _state.TowerB, _state.TowerC);
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Ilosc krazkow</param>
        /// <param name="A">Slupek zrodlowy</param>
        /// <param name="B">Słupek pomocniczy (bufor)</param>
        /// <param name="C">Słupek docelowy</param>
        private void _Solve(int n, Stack<int> A, Stack<int> B, Stack<int> C)
        {
            if (n == 0) return;
            _display.Display(_state);
            _Solve(n - 1, A, C, B);
            C.Push(A.Pop());
            _display.Display(_state);
            _Solve(n - 1, B, A, C);
            _display.Display(_state);
        }
    }
}
