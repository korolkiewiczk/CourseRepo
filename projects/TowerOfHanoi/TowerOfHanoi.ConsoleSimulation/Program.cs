using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TowerOfHanoi.Logic;

namespace TowerOfHanoi.ConsoleSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Logic.Algorithm(5, new Display());
            algorithm.Solve();
        }
    }

    internal class Display : IDisplay
    {
        void IDisplay.Display(State state)
        {
            Console.Clear();
            DisplayTower(state.TowerA, 0);
            DisplayTower(state.TowerB, 10);
            DisplayTower(state.TowerC, 20);
            Thread.Sleep(200);
        }

        private void DisplayTower(Stack<int> tower, int x)
        {
            Console.SetCursorPosition(x, 5-tower.Count);
            foreach (var item in tower)
            {
                Console.SetCursorPosition(x, Console.CursorTop+1);
                Console.Write(new string('*', item + 1) + " ");
            }
        }
    }

}
