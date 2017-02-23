
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2. Ankieta
//Napisać program w którym na wejściu zadajemy pytanie a komputer odpowiada nam w sposób losowy jednym ze sformułowań: 
//   Tak, Nie, Nie wiem.Wykorzystać klasę Random: https://msdn.microsoft.com/pl-pl/library/zd1bc8e5(v=vs.110).aspx
//Zakończenie programu odbywa się po wpisaniu słowa Koniec.

//Zadanie dodatkowe: dodać więcej sformułowań i dodatkowo sprawdzać czy pytanie zaczyna się od słowa Czy 
//   (jeśli tak, to wybieramy jedną z odpowiedzi Tak, Nie lub Nie wiem, w przeciwnym wypadku inną).



namespace Ankieta
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] randomAnswers = { "Tak", "Nie", "Może", "Być może", "Niewiem", "Prawdopodobnie", "Raczej nie", "Jest taka możliwość", "Ni huja!" };
            string question;


            Console.WriteLine("Pytaj o co tylko chcesz. Żeby zakończyć wpisz - Koniec - ");

            do
            {
                string prefix;
                Console.WriteLine("Twoje Pytanie to: ");
                question = Console.ReadLine();
                try
                {
                     prefix = question.Substring(0, question.IndexOf(" ")).ToLower();
                }
                catch
                {
                    prefix = "";
                }

                if (prefix == "czy")
                {
                    Console.WriteLine(randomAnswers[rnd.Next(randomAnswers.Length)]);
                }

                else if (prefix == "")
                {
                    Console.WriteLine("To chyba nie jest pytanie! Ogarnij sie!");
                }

                else                
                {
                    Console.WriteLine("Nie umiem jeszcze odpowiadać na takie pytania");
                }

                
                Console.WriteLine("");


            } while (question.ToLower() != "koniec");
        }
    }
}
