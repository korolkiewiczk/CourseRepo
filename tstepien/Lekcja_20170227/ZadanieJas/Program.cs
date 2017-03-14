using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieJas
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputWysokosciRurkiIIlosciKrazkow = Console.ReadLine().Split(null);
            int wysokoscRurki = int.Parse(inputWysokosciRurkiIIlosciKrazkow[0]);
            int iloscKrazkow = int.Parse(inputWysokosciRurkiIIlosciKrazkow[1]);

            int[] szerokosciRurki = new int[wysokoscRurki];
            int[] szerokosciKrazkow = new int[iloscKrazkow];

            var szerokosciRurkiZInputu = Console.ReadLine().Split(null);
            var szerokosciKrazkowZInputu = Console.ReadLine().Split(null);

            for (int i = 0; i < szerokosciRurkiZInputu.Length; i++) szerokosciRurki[i] = int.Parse(szerokosciRurkiZInputu[i]);
            for (int j = 0; j < szerokosciKrazkowZInputu.Length; j++) szerokosciKrazkow[j] = int.Parse(szerokosciKrazkowZInputu[j]);
            int dolnyPoziomRurki = wysokoscRurki;
            for (int numerKrazka=0;numerKrazka<iloscKrazkow; numerKrazka++)
            {
                for (int poziomRurki = 0; poziomRurki < dolnyPoziomRurki; poziomRurki++)
                {
                    if (szerokosciKrazkow[numerKrazka]>szerokosciRurki[poziomRurki]) dolnyPoziomRurki = poziomRurki;
                   // else if (i==n-1 && (k[j] <= r[i] || k[j] == r[i])) n = i;
                }
            }
            Console.WriteLine("Odpowiedz = {0}", dolnyPoziomRurki);
            Console.ReadKey();
        }
    }
}
