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
            Console.WriteLine("Unesite broj članova reda: ");
            int brojClanova = int.Parse(Console.ReadLine());

            double suma = 0.0;
            for (int i = 1; i <= brojClanova; i++)
            {
                suma += 1.0 / Math.Pow(3, i);
            }
            Console.WriteLine("Suma reda je: " + suma);
        }
    }
}


