using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtils
{
    public class GetDataFromConsole
    {

        //public string GetDataFromConsole()
        //{
        //    string usersInput = Console.ReadLine().Trim();
        //    return usersInput;
        //}


        //public void IsExitWord(string input) //??
        //{
        //}


        public int GetInt32(string paramName = "")
        {
            bool isCorrect = false;
            int x;
            string usersInput;
            do
            {
                Console.Write("Podaj parametr " + paramName + " (Int32): ");
                usersInput = Console.ReadLine().Trim();
                try
                {
                    x = Convert.ToInt32(usersInput);
                    isCorrect = true;
                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Niestety nie jest to Int32. Spróbuj ponownie.");
                };

            } while (!isCorrect);

            return -1;
        }



        public string GetString()
        {


            return "d";

        }





    }
}
