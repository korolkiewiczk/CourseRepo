using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course27032017
{
    class Program
    {
        static void Main(string[] args)
        {
            Binder binder=new Binder();
            for (int i = 0; i < 4; i++)
            {
            
                var line = Console.ReadLine();
                string[] tokens=line.Split();
                Console.WriteLine("ID dokumentu: "+binder.AddDocument(tokens[0],tokens[1]));
            }
            Console.WriteLine("Podaj id elem");
            string readId = Console.ReadLine();
            int id = int.Parse(readId);
            Console.WriteLine(binder.GetDocumentContent(id));
        }
    }
}
