using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamianaMiejsc4x
{
    class Program
    {

        static int getAndCheckValue(string question)
        {
            string line;
            int checkedValue;

            Console.WriteLine(question);
            line = Console.ReadLine();

            while (!Int32.TryParse(line, out checkedValue))
            {
                Console.WriteLine("Nieprawidłowa wartość. Spróbuj raz jeszcze");
                line = Console.ReadLine();
            };
            return checkedValue;
        }



        static void Main(string[] args)
        {
            int a, b, c, d;
            string line="", newline="";     
            a = getAndCheckValue("Podaj wartośc a");
            b = getAndCheckValue("Podaj wartośc b");
            c = getAndCheckValue("Podaj wartośc c");
            d = getAndCheckValue("Podaj wartośc d");

            Console.WriteLine("Podaj ciag znaków do obróbki");
            Console.WriteLine(new string('X', a+b+c+d));
            line = Console.ReadLine();

            while (line.Length != a+b+c+d)
            {
                Console.WriteLine("Zła długość, podaj jeszcze raz");
                Console.WriteLine(new string('X', a + b + c + d));
                line = Console.ReadLine();
            }

            newline = line;

            do
            {
                string a_part, b_part, c_part, d_part;

                a_part = newline.Substring(0, a);
                b_part = newline.Substring(a, b);
                c_part = newline.Substring(a + b, c);
                d_part = newline.Substring(a + b + c, d);

             //   Console.WriteLine("a: " + a_part + "  b: " + b_part + "  c: " + c_part+ "  d: "+d_part);

                newline = b_part + d_part + a_part + c_part;
                Console.WriteLine(newline);
                Console.WriteLine(" ");

            } while (newline != line);



            Console.ReadKey();

        }
    }
}
