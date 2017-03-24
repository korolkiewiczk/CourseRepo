using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Zamiana
    {

        string[] parameters = { "a", "b", "c", "d", "e", "f" };
        string[] newOrder = { "b", "d", "a", "c", "f", "e"};
        string baseText, subText, tempText, modifiedText;
        int lengthSum = 0;
        int tempIndex;
        bool containsUpperLetter, isCorrect;
        Dictionary<string, int> variables = new Dictionary<string, int>();
        Dictionary<string, string> substrings = new Dictionary<string, string>();


        public void Runme()
        {

            foreach (string param in parameters)
            {
                variables.Add(param, 0);
                substrings.Add(param, "");
            }


            foreach (string param in parameters) 
            {
                isCorrect = false;
                do {
                  
                    Console.Write("Podaj " + param + ":");

                    try
                    {
                        int v = Convert.ToInt32(Console.ReadLine());
                        lengthSum += v;
                        variables[param] = v;
                        isCorrect = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Niestety buont.");
                    };

                } while (!isCorrect);

            }

            Console.WriteLine("Mamy to!");
            foreach (var pair in variables)
            {
                Console.WriteLine(pair);
            }

            Console.WriteLine("Podaj tekst dla maski:");
            Console.WriteLine(new string('x', lengthSum));
            baseText = (Console.ReadLine());

            containsUpperLetter = Program.containsUpperLetter(baseText);

            modifiedText = baseText;

            do {

                tempText = "";
                cutIt(modifiedText);
                foreach (var param in newOrder)
                {
                    tempText += substrings[param];
                    Console.WriteLine(tempText);
                }

                modifiedText = tempText;

                Console.ReadLine();

            } while (baseText != modifiedText);

        }

        private void cutIt(string text)
        {
            tempIndex = 0;
            foreach (var param in parameters)
            {
                subText = text.Substring(tempIndex, variables[param]);
                tempIndex += variables[param];
                substrings[param] = subText;
            }
        }
    }
}
