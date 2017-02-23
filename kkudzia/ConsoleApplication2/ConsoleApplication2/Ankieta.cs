using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    class Ankieta
    {

        string[] standardAnswer = { "Tak.", "Nie.", "Nie wiem." };
        string[] differentAnswer = { "Co?", "Chyba Ty!", "Weź się...", "Owszem.", "Nie!", "F*ck it!" };

        Random rnd = new Random();
        int ansIndex;
        string question;

        public void runme()
        {

            while (true)
            {
                Console.WriteLine("Your question:");
                question = Console.ReadLine();
                question = question.ToLower();
                Console.WriteLine(question);
                if (question.Length >= 6 && question.Substring(0, 6) == "koniec") { break; }

                try
                {
                    Console.WriteLine(chooseAnswer(
                        (question.Substring(0, 3) == "czy") ? standardAnswer : differentAnswer
                        ));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Pierdoły opowiadasz.");

                }
            }
        }

        private string chooseAnswer(string[] ansTable)
        {
            return ansTable[rnd.Next((ansTable.Length) - 1)];
        }

    }

}
