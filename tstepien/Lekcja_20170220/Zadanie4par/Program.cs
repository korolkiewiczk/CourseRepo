using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4par
{
    class Program
    {
        static void Main(string[] args)
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
                Console.Write("Podaj liczbe D : "); 1
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
    }
}
