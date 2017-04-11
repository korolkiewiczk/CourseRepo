using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrazkiDictionary
{
    class Program
    {
        static Dictionary<int, Rurka> dRurka = new Dictionary<int, Rurka>();
        static Dictionary<int, Krazek> dKrazek = new Dictionary<int, Krazek>();
        static int iloscRurek;
        static int maxRurka;
        static int iloscKrazkow;
        static int maxKrazka;
        static int i = 0;

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Temat();
            Console.Write("Podaj ilosc rurek : ");
            iloscRurek = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj max rozmiar rurki : ");
            maxRurka = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (i > 0)
                {
                    Console.WriteLine("Ilosc krazkow jest wieksza o ilosci rurek, podaje jeszcze raz!");
                }
                Console.Write("Podaj ilosc krazkow : ");
                iloscKrazkow = Convert.ToInt32(Console.ReadLine());
                i++;
            } while (iloscKrazkow > iloscRurek);

            Console.Write("Podaj max rozmiar krazka : ");
            maxKrazka = Convert.ToInt32(Console.ReadLine());

            WpisywanieIlosc();
            Obliczenia();
            Console.ReadKey();
        }

        private static void Obliczenia()
        {
            throw new NotImplementedException();
        }

        private static void WpisywanieIlosc()
        {
            for (int i = 1; i <= iloscRurek; i++)
            {
                dRurka.Add(i, new Rurka { wymiarRurki = rnd.Next(1, maxRurka) });
            }
            for (int i = 1; i <= iloscKrazkow; i++)
            {
                dKrazek.Add(i, new Krazek { wymiarKrazka = rnd.Next(1, maxKrazka) });
            }
        }

        private static void Temat()
        {
            Console.WriteLine("-------------- \tPROGRAM KRAZEK\t --------------");
        }
    }
    public class Rurka
    {
        public int wymiarRurki { get; set; }
    }
    class Krazek
    {
        public int wymiarKrazka { get; set; }
    }
}
