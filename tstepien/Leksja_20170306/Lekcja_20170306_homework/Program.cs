using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_20170306_homework
{
    class Program
    {
        private static Dictionary<string, Func<string, string, string>> _operators = new Dictionary<string, Func<string, string, string>>()
        {
            {"+", concat }
            //{"-", del1 },
            //{"*", add },
            //{"/", polowa }
        };

        static string concat(string t1, string t2)
        {
            return t1 + t2;
        }
        static void Main(string[] args)
        {
            string tekst = Console.ReadLine();

            var tokens = tekst.Split();

            Console.WriteLine(toke)

            Console.ReadKey();
        }
    }
}
