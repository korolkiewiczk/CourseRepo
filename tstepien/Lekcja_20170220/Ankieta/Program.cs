using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankieta
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
