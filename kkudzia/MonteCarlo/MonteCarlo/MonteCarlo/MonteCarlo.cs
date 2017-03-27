using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    class MonteCarlo
    {

        static CommonUtils.GetDataFromConsole _common = new CommonUtils.GetDataFromConsole();
        static private double _radius = (double) _common.GetInt32("promień");
        static private double[] _point = new double[2];
        static private double _squareArea = Math.Sqrt(_radius * 2);
        static private double _numberOfPoints = _common.GetInt32("liczba punktów");
        static private double _numberOfPointsBelonging = 0;
        static Random rand = new Random();


        static void Main(string[] args)
        {


            for (int n = 1; n <= _numberOfPoints; n++)
            {
                DrawPointInSquare();
                _numberOfPointsBelonging += (IsPointBelongs()) ? 1 : 0;

                Console.WriteLine(_numberOfPointsBelonging + " out of " + _numberOfPoints + " points belongs, percentage: " + CalculatePercentage() + " %");

            }

            double _circleArea = _squareArea * (_numberOfPointsBelonging / _numberOfPoints);

            Console.WriteLine("Area of the circle is: " + _circleArea + " (" + CalculatePercentage() + "% of " + _squareArea + ").");

            Console.ReadKey();

        }

        static void DrawPointInSquare()
        {
            _point[0] = (rand.NextDouble() * _radius);
            _point[1] = (rand.NextDouble() * _radius);
        }

        static bool IsPointBelongs()
        {
            return (Math.Pow(_point[0], 2) + Math.Pow(_point[1], 2) <= Math.Pow(_radius, 2)) ? true : false;
        }

        static double CalculatePercentage()
        {
            return Math.Round(((_numberOfPointsBelonging / _numberOfPoints) * 100), 2);

        }

    }
}
