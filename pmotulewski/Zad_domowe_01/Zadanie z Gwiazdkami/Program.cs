using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//*** Jak w programie podstawowym, ale wynik ma być poprawniony wg.konwencji 
//    a->b, e->f, i->j, o->p, u->v, y->z, zarówno małych i dużych (czyli zamieniamy samogłoskę na sąsiadującą z nią spółgłoskę). 
//Należy wykorzystać instrukcję switch i użyć StringBuilder.

//    Przykład: MaKotaAla ->MbKptbBlb


namespace Zadanie_z_Gwiazdkami
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


        static string doACode(string original)
        {
            StringBuilder coded = new StringBuilder();
            coded.Clear();
            foreach (char item in original)
            {
                switch (item)
                {
                    case 'a': coded.Append("b"); break;
                    case 'A': coded.Append("B"); break;
                    case 'e': coded.Append("f"); break;
                    case 'E': coded.Append("F"); break;
                    case 'i': coded.Append("i"); break;
                    case 'I': coded.Append("J"); break;
                    case 'o': coded.Append("p"); break;
                    case 'O': coded.Append("P"); break;
                    case 'u': coded.Append("v"); break;
                    case 'U': coded.Append("V"); break;
                    case 'y': coded.Append("z"); break;
                    case 'Y': coded.Append("Z"); break;

                    default:
                        coded.Append(item);
                        break;                   
                     
                }
            }



            return coded.ToString();

        }



        static void Main(string[] args)
        {
            int a, b, c, d;
            string line = "", newline = "";
            a = getAndCheckValue("Podaj wartośc a");
            b = getAndCheckValue("Podaj wartośc b");
            c = getAndCheckValue("Podaj wartośc c");
            d = getAndCheckValue("Podaj wartośc d");

            Console.WriteLine("Podaj ciag znaków do obróbki");
            Console.WriteLine(new string('X', a + b + c + d));
            line = Console.ReadLine();

            while (line.Length != a + b + c + d)
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
                Console.WriteLine(newline + " - Ciąg zamieniony -> " + doACode(newline));
                Console.WriteLine(" ");

            } while (newline != line);



            Console.ReadKey();

        }
    }
}
