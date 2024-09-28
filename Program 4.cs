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
            Console.WriteLine("Unesite tri cijela broja (x, y, z) za stranice pravokutnog trokuta: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            if (x <= 0 || y <= 0 || z <= 0)
            {
                Console.WriteLine("Stranice trokuta moraju biti veće od 0!");
            }
            else
            {
                if (x * x + y * y == z * z || x * x + z * z == y * y || y * y + z * z == x * x)
                {
                    Console.WriteLine("Stranice tvore pravokutni trokut.");
                }
                else
                {
                    Console.WriteLine("Stranice ne tvore pravokutni trokut.");
                }
            }
        }
    }
}


