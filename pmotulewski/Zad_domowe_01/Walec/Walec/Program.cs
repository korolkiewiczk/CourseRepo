using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walec
{
    class Program
    {
        static void Main(string[] args)
        {
            int pipe_height, ammount_of_disc=0;
            int[] pipe;
            int[] discs;
            bool is_Correct = false;

            do
            {
                char space = ' ';
                Console.WriteLine("Podaj Wysokośc rurki i liczbę dysków kóra zamierzasz wrzucić oddzielone spacją");
                string height_and_discs = Console.ReadLine();

                if (height_and_discs.Split(space).Length == 2)
                {
                    if (Int32.TryParse(height_and_discs.Split(space)[0], out pipe_height) & Int32.TryParse(height_and_discs.Split(space)[1], out ammount_of_disc))
                    {
                        is_Correct = true;
                                           }
                }
                else { is_Correct = false; }
            } while (is_Correct == false);


            do
            {
                char space = ' ';
                Console.WriteLine("Podaj promienie walców oddzielone spacjami. Walców ma być " + ammount_of_disc.ToString());

            } while (is_Correct == false);



        }
    }
}
