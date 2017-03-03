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
            //int n=7, m=3;
            var nm = Console.ReadLine().Split(null);
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            int[] r = new int[n];
            int[] k = new int[m];

            var rx = Console.ReadLine().Split(null);
            var kx = Console.ReadLine().Split(null);

            for (int i = 0; i < rx.Length; i++) r[i] = int.Parse(rx[i]);
            for (int j = 0; j < kx.Length; j++) k[j] = int.Parse(kx[j]);

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
