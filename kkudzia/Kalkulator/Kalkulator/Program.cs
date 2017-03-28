using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {

        private static Dictionary<string, Func<double, double, double>> _operators = new Dictionary<string, Func<double, double, double>>();


        static void Main(string[] args)
        {

            CreateOperators();

            string expression = Console.ReadLine();


            //double x = double.Parse(Console.ReadLine());
            //double y = double.Parse(Console.ReadLine());
            //string @operator = Console.ReadLine();

            //Console.WriteLine(_operators[@operator](x, y));

            

            var tokens = expression.Split();
            Stack<int> stack = new Stack<int>();
            int value;

            foreach (var token in tokens)
            {
                if (int.TryParse(token, out value))
                {
                    stack.Push(value);

                }
                else {

                    int a = stack.Pop();
                    int b = stack.Pop();

                    stack.Push((int)_operators[token](a, b));
                }

            }

            Console.WriteLine(stack.Peek());


        }

        private static void CreateOperators()
        {
            _operators.Add("+", (x, y) => x + y);
            _operators.Add("-", (x, y) => x - y);
            _operators.Add("*", (x, y) => x * y);
            _operators.Add("/", (x, y) => x / y);
            _operators.Add("%", (x, y) => x % y);
            _operators.Add("&", (x, y) => (int)x & (int)y);
            _operators.Add("SIN", (x, y) => Math.Sin(x));
        }



    }
}
