using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicijalni
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Unesite broj članova niza: ");
            int brojClanova = int.Parse(Console.ReadLine());

            int[] niz = new int[brojClanova];

           
            Console.WriteLine("Unesite članove niza: ");
            for (int i = 0; i < brojClanova; i++)
            {
                niz[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(niz);
            Console.WriteLine("Sortirani niz: " + string.Join(" ", niz));
        }
    }
}


