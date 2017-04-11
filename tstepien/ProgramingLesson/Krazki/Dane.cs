using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krazki
{
    public class Dane
    {
        static List<Rurka> rurka = new List<Rurka>();
        static List<Krazek> krazek = new List<Krazek>();

        public void daneRurki()
        {
            Console.Write("Podaj liczbe rurek = ");
            int liczbaRurek = Convert.ToInt32(Console.ReadLine());
            int _nrRurki;

            for (int i=1; i <= liczbaRurek; i++)
            {
                Console.Write("Podaj rozmiar {0} rurki : ", i);
                _nrRurki = Convert.ToInt32(Console.ReadLine());
                rurka.Add(new Rurka { idRurki = i, nrRurki = _nrRurki });
            }
        }
        public void daneKrazka()
        {
            Console.Write("Podaj liczbe krazkow = ");
            int liczbaKrazkow = Convert.ToInt32(Console.ReadLine());
            int _nrKrazka;

            for (int i = 1; i <= liczbaKrazkow; i++)
            {
                Console.Write("Podaj rozmiar {0} rurki : ", i);
                _nrKrazka = Convert.ToInt32(Console.ReadLine());
                krazek.Add(new Krazek { idKrazka = i, nrKrazka = _nrKrazka });
            }
        }
    }
}
