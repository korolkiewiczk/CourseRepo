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
            int odp = 0;
            r[0] = 5; r[1] = 6; r[2] = 4; r[3] = 3; r[4] = 6; r[5] = 2; r[6] = 3;
            k[0] = 3; k[1] = 2; k[2] = 5;

            /*
            for (int i=1;i<=n;i++)
            {
                r[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j=1;i<=m;j++)
            {
                k[j] = Convert.ToInt32(Console.ReadLine());
            }
            */
            for (int j=0;j<m; j++)
            {
                for (int i = n-1; i >= 0; i--)
                {
                    if (r[i]>k[j])
                    {
                        i++;
                        break;
                    }
                    else
                    {
                        odp = r[i];
                    }
                }
            }
            Console.WriteLine("Odpowiedz = {0}",odp);

            Console.ReadKey();
        }
    }
}
