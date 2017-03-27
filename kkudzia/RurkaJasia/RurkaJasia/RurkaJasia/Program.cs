using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RurkaJasia
{
    class Program
    {

        private static int _tubeHeight, _numberOfWheels;
        private static Dictionary<int, int> _tubeMask = new Dictionary<int, int>();
        private static int _result;

        static void Main(string[] args)
        {

            GetTubeHeightAndNumberOfWheels();

            SetTubeMask();

            ThrowWheels();

            // Wypiywanie leveli dla poszczegolnych zawezen
            // foreach (int key in _tubeMask.Keys) { Console.WriteLine("klucz: " + key + " warosc: " + _tubeMask[key]); }

            Console.WriteLine(_result);

            Console.ReadKey();

        }


        static void GetTubeHeightAndNumberOfWheels()
        {

            string[] firstLine = Console.ReadLine().Split();
            _tubeHeight = Convert.ToInt32(firstLine[0]);
            _numberOfWheels = Convert.ToInt32(firstLine[1]);

        }


        static void SetTubeMask()
        {

            string[] secondLine = Console.ReadLine().Split();

            int level = 0;
            int levelWidth;
            int smallestLevelWidth = Int32.MaxValue;

            foreach (string numberString in secondLine)
            {
                level++;
                levelWidth = Convert.ToInt32(numberString);

                if (!_tubeMask.Keys.Contains(levelWidth) && levelWidth < smallestLevelWidth)
                {
                    _tubeMask.Add(levelWidth, level);
                }

                smallestLevelWidth = (levelWidth < smallestLevelWidth) ? levelWidth : smallestLevelWidth;

            }

            _tubeMask.Add(0, secondLine.Length);


        }


        static void ThrowWheels()
        {

            int wheelWidth;
            int lowestEmptyLevel = _tubeMask[0];

            string[] thirdLine = Console.ReadLine().Split();
            foreach (var wheel in thirdLine)
            {

                wheelWidth = Convert.ToInt32(wheel);

                int nearestSmallerSizeKey = FindNearestSmallerSize(wheelWidth);

                lowestEmptyLevel = (_tubeMask[nearestSmallerSizeKey] > lowestEmptyLevel) ? lowestEmptyLevel - 1 : _tubeMask[nearestSmallerSizeKey] - 1;

                _result = lowestEmptyLevel;

                if (_result == 0) { break; }

            }
        }


        static int FindNearestSmallerSize(int wheelWidth)
        {

            int smallerSize = wheelWidth - 1;

            while (!_tubeMask.ContainsKey(smallerSize))
            {
                smallerSize--;
            }

            return smallerSize;

        }

    }
}
