using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Logic
{
    public class State
    {
        public State(int n)
        {
            TowerA = new Stack<int>(n);
            for (int i = n - 1; i >= 0; i--)
            {
                TowerA.Push(i);
            }
            TowerB = new Stack<int>();
            TowerC = new Stack<int>();
        }

        public Stack<int> TowerA { get; }
        public Stack<int> TowerB { get; }
        public Stack<int> TowerC { get; }
    }
}
