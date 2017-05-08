using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2
{
    class Program
    {
        static Dictionary<string, Func<double, double, double>> _operators = new Dictionary<string, Func<double, double, double>>
        {
            {"+", Add },
            {"-", Subtract }
        };

        // Delegat > Wskaźnik na funkcje


        static double Add (double x, double y)
        {
            return x+y;
        }

        static double Subtract (double x, double y)
        {
            return x - y;
        }

        private static void CreateOperators()
        {
            _operators.Add("*", (x, y) => x * y);
            _operators.Add("/", (x, y) => x / y);
            _operators.Add("%", (x, y) => x % y);
            _operators.Add("&", (x, y) => (int)x & (int)y);
            _operators.Add("SIN", (x, y) => Math.Sin(x));
        }

        static void Main(string[] args)
        {
            CreateOperators();

            //double x = double.Parse(Console.ReadLine());
            //double y = double.Parse(Console.ReadLine());
            //string @operator = Console.ReadLine();
            //Console.WriteLine(_operators[@operator](x,y));

            string expression = Console.ReadLine();

            var tokens = expression.Split();
            Stack<int> stack = new Stack<int>();
            foreach (var token in tokens)
            {
                int value;
                
                if (int.TryParse(token, out value))
                {
                    stack.Push(value);
                }

                else
                {
                    int a = stack.Pop();
                    int b = stack.Pop();

                    stack.Push((int)_operators[token](a, b));

                }

                Console.WriteLine(stack.Peek());
                //Peek - pobiera ostatnia wartosc ze stosu, ale jej nie zdejmuje 
            }

           

        }
    }
}
