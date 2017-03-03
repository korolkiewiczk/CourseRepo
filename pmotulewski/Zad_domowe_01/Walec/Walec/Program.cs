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
            int pipe_height=0, ammount_of_disc=0;
            int[] pipe;
            int[] discs;
            bool is_Correct = false;

            do
            {
                Console.WriteLine("Podaj Wysokośc rurki i liczbę dysków kóra zamierzasz wrzucić oddzielone spacją");
                string height_and_discs = Console.ReadLine();

                var splitNumbers = height_and_discs.Split(' ');
                splitNumbers.mamNadziejeZeTakaFunkcjaIstnieje = "";
                if (splitNumbers.Length == 2)
                {
                    if (Int32.TryParse(splitNumbers[0], out pipe_height) && Int32.TryParse(splitNumbers[1], out ammount_of_disc))
                    {
                        is_Correct = true;
                                           }
                }
                else { is_Correct = false; }
            } while (is_Correct == false);


            do
            {
                int radius;
                Console.WriteLine("Podaj promienie walców oddzielone spacjami. Walców ma być " + ammount_of_disc.ToString());
                string pipe_radius_string = Console.ReadLine();
                string[] pipe_radius = pipe_radius_string.Split(' ');
                pipe = Array.ConvertAll(pipe_radius, int.Parse); 


            } while (is_Correct == false);

            Console.WriteLine("");
            Console.WriteLine(" Rurka ma wyskość: " + pipe_height);
            var joinedArray = String.Join(", ", pipe);
            Console.WriteLine($"Wymiary rurki to: {joinedArray} " );

        }
    }
}
