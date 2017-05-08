using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binder
{
    class Start
    {


        private static Dictionary<string, Func<string[]>> _operators = new Dictionary<string, Func<string[]>>();
        private static string[] UsersData = new string[3];


        private static void CreateOperators()
        {
            //_operators.Add("+", (UsersData) => String.Concat(s1, s2));
            //_operators.Add("-", (UsersData) => s1.Remove(s1.Length - 1, 1));
            //_operators.Add("#", (UsersData) => String.Concat(s1, s1));
            //_operators.Add("@", (UsersData) => s1.Substring(0, s1.Length / 2));
            //_operators.Add(">", (UsersData) => s1.Substring(0, s1.Length / 2));
            //_operators.Add("<", (UsersData) => s1.Substring(0, s1.Length / 2));
            //_operators.Add("exit", (UsersData) => do smth());

        }


        private static void GetUserData()
        {

            int SpaceIndex;
            
            string expression = Console.ReadLine().Trim();  
            var tokens = expression.Split();

            do {
                if (expression.Contains(" "))
                {
                    SpaceIndex = expression.IndexOf(" ");
                }

            }

            while (UsersData[2] != null);



            


            


            UsersData[0] = tokens[0];
            UsersData[1] = (tokens[1] != null)? tokens[1] : null;


            if (UsersData[2] != null)
            {

                expression

            }





            //Stack<string> stack = new Stack<string>();

            foreach (var token in tokens)
            {





                if (!_operators.ContainsKey(token))
                {
                    stack.Push(token);
                }
                else {

                    string s1 = stack.Pop();
                    string s2 = token == "+" ? stack.Pop() : "";

                    stack.Push((string)_operators[token](s1, s2));
                }

            }



        }


        static void Main(string[] args)
        {

            CreateOperators();



            Console.WriteLine(stack.Peek());
            Console.ReadKey();


            // konsola
            // slowo wyjscia

            // mapowanie funcji










            // + - # @ > <






        }
    }
}
