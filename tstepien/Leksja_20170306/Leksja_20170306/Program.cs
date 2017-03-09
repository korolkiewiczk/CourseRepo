using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leksja_20170306
{
    class Program
    {

        private static Dictionary<string, Func<double, double, double>> _operators = new Dictionary<string, Func<double, double, double>>()
        {
            {"+", Add },
            {"-", Substract }
        };
        //slownik moze przychowywac dowolna liczbe danych i przeszukiwanie jest bardzo szybkie

        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Substract(double x, double y)
        {
            return x - y;
        }
        static void Main(string[] args)
        {
            CreateOperators();
            //kal1();

            string expression = Console.ReadLine();

            var tokens = expression.Split();
            Stack<int> stack = new Stack<int>();            //sztos

            foreach (var token in tokens)
            {
                int value;
                if(int.TryParse(token, out value))
                {
                    stack.Push(value);
                }
                else
                {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push((int)_operators[token](a, b));
                }
            }
            Console.WriteLine(stack.Peek()); //peek - pobiera ale nie zdejmuje

        }

        static void kal1()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            Console.WriteLine(_operators[@operator](x, y));
        }

        private static void CreateOperators()
        {
            _operators.Add("*", (x, y)=> x * y);                //wyraznie lambda
            _operators.Add("/", (x, y) => x / y);
            _operators.Add("%", (x, y) => x % y);
            _operators.Add("&", (x, y) => (int) x & (int) y);
            _operators.Add("SIN", (x, y) => x * y);
            _operators.Add("*", (x, y) => Math.Sin(x));
        }
    }
}
