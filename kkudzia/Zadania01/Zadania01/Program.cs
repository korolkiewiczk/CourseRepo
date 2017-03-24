using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {


            Alamakota ala = new Alamakota();
            Zamiana zamianka = new Zamiana();
            Ankieta ankietka = new Ankieta();
            
            
            //ala.runme();
            zamianka.Runme();
            //ankietka.Runme();

            Console.ReadKey();

        }


        public static bool containsUpperLetter(string text)
        {

            foreach (var letter in text)
            {
               if (char.IsUpper(letter))
               {
                    return true;
               }
            }

            return false;
        }







    }
}
