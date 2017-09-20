using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            LosowaniaDuzegoLotka losowanieLotka = new LosowaniaDuzegoLotka();
            LiczbySkreslone skreslone = new LiczbySkreslone();

            skreslone.LiczbySkreslonePrzezUzytkownika();

            SprawdzanieCzyTrafione sprawdzanie = new SprawdzanieCzyTrafione(losowanieLotka.liczbyDuzegoLotka, skreslone.skreslone);

            foreach (var item in sprawdzanie.trafione)
            {
                Console.WriteLine($"Trafiles liczbe = {sprawdzanie.trafione}");
            }
            Console.ReadKey();
        }
    }

    class SprawdzanieCzyTrafione
    {
        public List<int> trafione = new List<int>();

        public SprawdzanieCzyTrafione(int[] lotto, int[] skreslone)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (lotto[j] == skreslone[i])
                    {
                        trafione.Add(skreslone[i]);
                        break;
                    }
                }
            }
        }
    }

    public class LiczbySkreslone
    {
        public int[] skreslone = new int[6];

        SprawdzanieLiczb unikatowe = new SprawdzanieLiczb();

        public void LiczbySkreslonePrzezUzytkownika()
        {
            bool spr = false;

            for (int i = 0; i < 6; i++)
            {
                do
                {
                    Console.Write($"Podaj {i + 1} / 6 liczbe = ");
                    skreslone[i] = Convert.ToInt32(Console.ReadLine());
                    spr = (skreslone[i] > 0 && skreslone[i] < 50) ? false : true;
                } while (spr);

                i = unikatowe.FnLiczbyUnikatowe(skreslone, skreslone[i], i);
            }
        }
    }

    public class LosowaniaDuzegoLotka
    {
        public int[] liczbyDuzegoLotka = new int[6];

        public LosowaniaDuzegoLotka()
        {
            SprawdzanieLiczb sprawdzanie = new SprawdzanieLiczb();
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                liczbyDuzegoLotka[i] = rnd.Next(1, 49);
                i = sprawdzanie.FnLiczbyUnikatowe(liczbyDuzegoLotka, liczbyDuzegoLotka[i], i);
            }
        }
    }

    public class SprawdzanieLiczb
    {
        public int FnLiczbyUnikatowe(int[] tablicaLiczb, int liczbaDoSprawdzenia, int nrLosowania)
        {
            for (int i = 0; i < nrLosowania; i++)
            {
                nrLosowania = (tablicaLiczb[i] == liczbaDoSprawdzenia) ? nrLosowania - 1 : nrLosowania;
            }
            return nrLosowania;
        }
    }
}