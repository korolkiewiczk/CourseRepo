using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalc
{
    class Program
    {


        private static Dictionary<string, Func<string, string, string>> _operators = new Dictionary<string, Func<string, string, string>>();

        static void Main(string[] args)
        {

            CreateOperators();

            string expression = Console.ReadLine();

            var tokens = expression.Split();
            Stack<string> stack = new Stack<string>();

            foreach (var token in tokens)
            {
                if (!_operators.ContainsKey(token))
                {
                    stack.Push(token);
                }
                else {

                    string s1 = stack.Pop();
                    string s2 = token == "+" ? stack.Pop(): "";

                    stack.Push((string)_operators[token](s1, s2));
                }

            }

            Console.WriteLine(stack.Peek());
            Console.ReadKey();

        }

        private static void CreateOperators()
        {
            _operators.Add("+", (s1, s2) => String.Concat(s1, s2));
            _operators.Add("-", (s1, s2) => s1.Remove(s1.Length-1, 1));
            _operators.Add("*", (s1, s2) => String.Concat(s1, s1));
            _operators.Add("/", (s1, s2) => s1.Substring(0, s1.Length/ 2));

        }



    }
}
