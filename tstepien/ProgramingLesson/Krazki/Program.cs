using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krazki
{
    class Program
    {
        static List<Rurka> rurka = new List<Rurka>();
        static List<Krazek> krazek = new List<Krazek>();

        static Dane dane = new Dane();

        static void Main(string[] args)
        {
            dane.daneRurki();
            Console.WriteLine();

            dane.daneKrazka();

            Console.WriteLine("liczba wpisow : {0}", rurka.count());

            Console.ReadKey();
        }
    }
}
