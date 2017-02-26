using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_20170220
{
    class Program
    {
        static void Main(string[] args)
        {
            //L20170220();
            //zadanieLekcjaGwiazdka();
            zadanie4par();
            //ankietaFull();
            Console.ReadKey();
        }
        public static void zadanie4par()
        {
            /*
            1.Zamiana miejsc 4x
            Zrobić analogiczny program z tym że będzie przyjmował 4 parametry: a,b,c,d oraz tekst wejściowy długości a+b + c + d.Następnie będzie wypisywał wszystkie unikalne kombinację.
            W każdej iteracji zamiana tekstu będzie wg.kolejności: b,d,a,c.
            * Dodać walidację wszystkich wprowadzonych danych z możliwością podania ich ponownie(stworzyć w miarę przyjazny interfejs użytkownika, np.Komunikat “Źle podałeś liczbę a, spróbuj ponownie”).
            Zobacz: http://stackoverflow.com/questions/4804968/how-can-i-validate-console-input-as-integers
            */
            int i = 1, a = 4, b = 5, c = 4, d = 3, x;
            string tx1; // = "AlaMaKotaFilemon";
            string tx2;

            //a = 3;b = 4;c = 4;d = 5;

            Console.Write("\n\nPROGRAM ZADANIE 1\n\n");
            Console.Write("Podaj slowo do zmiany :");
            tx1 = Console.ReadLine();
            tx2 = tx1;

            do
            {
                Console.WriteLine("Suma podanych 4 cyfr musi sie zgadzac z liczba liter!");
                Console.WriteLine("Podejscie {0}.", i);
                Console.Write("Podaj liczbe A : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj liczbe B : ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj liczbe C : ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj liczbe D : ");
                d = Convert.ToInt32(Console.ReadLine());
                x = a + b + c + d;
                i++;
            } while (x != tx1.Length);

            Console.WriteLine(tx1);
            do
            {
                string t1 = tx2.Substring(0, a);
                string t2 = tx2.Substring(a, b);
                string t3 = tx2.Substring(a + b, c);
                string t4 = tx2.Substring(a + b + c, d);
                tx2 = t2 + t4 + t1 + t3;
                Console.WriteLine(tx2);
            } while (tx2 != tx1);
        }
        public static void ankietaFull()
        {
            /*
            2.Ankieta
            Napisać program w którym na wejściu zadajemy pytanie a komputer odpowiada nam w sposób losowy jednym ze sformułowań: Tak, Nie, Nie wiem. Wykorzystać klasę
            Random: https://msdn.microsoft.com/pl-pl/library/zd1bc8e5(v=vs.110).aspx
            Zakończenie programu odbywa się po wpisaniu słowa Koniec.
            Zadanie dodatkowe: dodać więcej sformułowań i dodatkowo sprawdzać czy pytanie zaczyna się od słowa Czy(jeśli tak, to wybieramy jedną z odpowiedzi Tak, Nie lub Nie wiem, w przeciwnym wypadku inną).
            */
            Random r = new Random();
            int f;
            Console.WriteLine("PROGRAM ANKIETA");
            Console.WriteLine("Podaj pytanie jakie chcesz zadac, lub wpisz Koniec.");

            int i = 1;
            f = 1;
            while (f != 4)
            {
                Console.Write("Podaj pytanie nr {0} (Lub wpisz slowo Koniec) : ", i);
                i++;
                var an = Console.ReadLine();
                if (an == "Koniec")
                {
                    f = 4;
                }
                else if (an.Length > 3 && an.Substring(0, 3) == "Czy")
                {
                    Console.WriteLine("Inna Odpowiedz!");
                }
                else
                {
                    f = r.Next(1, 4);
                    Console.Write("Odpowiedz : ");
                    switch (f)
                    {
                        case 1: Console.WriteLine("Tak"); break;
                        case 2: Console.WriteLine("Nie"); break;
                        case 3: Console.WriteLine("Nie, wiem"); break;
                    }
                }
            }
        }

        public static void zadanieLekcjaGwiazdka()
        {
            /*
            ***Jak w programie podstawowym, ale wynik ma byc poprawniony wg. konwencji a->b, e->f, i->j, o->p, u->v, y->z, zarówno malych i duzych (czyli zamieniamy samogloske na sasiadujaca z nia spólgloske).
            *Nalezy wykorzystac instrukcje switch i uzyc StringBuilder.
            Przyklad:
            (dla danych wejsciowych z pierwszego przykladu)

            Output
            MbKptbBlb
            */
            int x = 4, y = 5, n = 3;
            string text1 = "AlaMaKota";

            Console.Write("x = {0}", x);
            Console.Write("\ty = {0}", y);
            Console.Write("\tn = {0}", n);

            var sb = new StringBuilder();

            foreach (char v in text1)
            {
                switch (Convert.ToString(v))
                {
                    case "a": sb.Append("b"); break;
                    case "A": sb.Append("B"); break;
                    case "e": sb.Append("f"); break;
                    case "E": sb.Append("F"); break;
                    case "i": sb.Append("j"); break;
                    case "I": sb.Append("j"); break;
                    case "o": sb.Append("p"); break;
                    case "O": sb.Append("P"); break;
                    case "u": sb.Append("v"); break;
                    case "U": sb.Append("V"); break;
                    case "y": sb.Append("z"); break;
                    case "Y": sb.Append("Z"); break;
                    default: sb.Append(v); break;
                }
            }
            var text2 = sb.ToString();
            string text1z = text1;
            string text2z = text2;

            Console.WriteLine("\n{0}", text1);

            for (int i = 0; i < n; i++)
            {
                string f1 = text1z.Substring(0, x);
                string l1 = text1z.Substring(x, y);
                text1z = l1 + f1;
                Console.WriteLine(text1z);
            }

            Console.WriteLine("\n{0}", text2);

            for (int i = 0; i < n; i++)
            {
                string f1 = text2z.Substring(0, x);
                string l1 = text2z.Substring(x, y);
                text2z = l1 + f1;
                Console.WriteLine(text2z);
            }



            /*
             * var ids = new[] { "1", "2", "3", "4" };
            var sb1 = new StringBuilder();
            foreach(var id in ids)
            {
                sb.Append(id);
            }
            var s = sb.ToString();
            Console.WriteLine(s);
            */
        }
        public static void L20170220()
        {
            int x, y, i = 0, n;
            string text;
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                i++;
                Console.Write("Your mask is ");
                for (int j = 0; j < x + y; j++)
                {
                    Console.Write("x");
                }
                if (i != 1)
                {
                    Console.WriteLine("\nText doesn't has {0} leter!", x + y);
                }
                Console.Write("\nWrite text = ");
                text = Console.ReadLine();
            } while (text.Length != x + y);

            var text2 = text;

            for (int k = 0; k < n; k++)
            {
                string first = text2.Substring(0, x);
                string last = text2.Substring(x, y);
                text2 = last + first;
                Console.WriteLine(text2);
            }

            i = 0;
            bool bigLeter = false;
            foreach (char c in text)
            {
                bigLeter = bigLeter ? bigLeter : char.IsUpper(c);
            }
            Console.WriteLine("Text has big leters : {0}", bigLeter);
        }
    }
}
