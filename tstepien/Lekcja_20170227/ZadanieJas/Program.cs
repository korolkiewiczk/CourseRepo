using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieJas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=7, m=3;
            //n = Convert.ToInt32(Console.ReadLine());
            //m = Convert.ToInt32(Console.ReadLine());
            int[] r = new int[n];
            int[] k = new int[m];
            r[0] = 5; r[1] = 6; r[2] = 4; r[3] = 3; r[4] = 6; r[5] = 2; r[6] = 3;
            //k[0] = 3; k[1] = 2; k[2] = 5;
            //k[0] = 5; k[1] = 2; k[2] = 5;
            //k[0] = 4; k[1] = 6; k[2] = 5;
            //k[0] = 7; k[1] = 1; k[2] = 1;

            for (int j=0;j<m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (k[j]>r[i])
                    {
                        n = i;
                    }
                    else if (i==n-1 && (k[j] <= r[i] || k[j] == r[i]))
                    {
                        n = i;
                    }
                }
            }
            Console.WriteLine("Odpowiedz = {0}",n);
            Console.ReadKey();
        }
    }
}
