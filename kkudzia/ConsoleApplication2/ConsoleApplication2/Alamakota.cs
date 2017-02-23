using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Alamakota
    {

        public void runme()
        {
            // Input: 4, 5, 3, AlaMaKota
            
            int x, y, n;
            string nazwa, newnazwa, vowel, consonant;
            string[] pairs = { "ab", "ef", "ij", "op", "uv", "yz" };
            StringBuilder tekst = new StringBuilder();

            Console.Write("Podaj x : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj y : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj n : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj text zgodny z maska: ");
            Console.WriteLine(new string('X', x + y));
            nazwa = (Console.ReadLine());

            tekst.Append(nazwa);

            foreach (var param in pairs)
            {
                vowel = param[0].ToString();
                consonant = param[1].ToString();
                tekst.Replace(vowel, consonant);
                tekst.Replace(vowel.ToUpper(), consonant.ToUpper());
            }

            nazwa = tekst.ToString();
            newnazwa = nazwa;
            bool maWielkaLitere = Program.containsUpperLetter(nazwa);

            do
            {
                string part1 = newnazwa.Substring(0, x);
                string part2 = newnazwa.Substring(x, y);
                newnazwa = part2 + part1;

                if (char.IsUpper(newnazwa[0]) || !maWielkaLitere)
                {
                    Console.WriteLine(newnazwa);
                }
            }
            while (nazwa != newnazwa);
        }
    }
}
