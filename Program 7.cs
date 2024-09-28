using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicijalni
{
    class Program
    {
        static bool JeProst(int broj)
        {
            if (broj < 2) return false;
            for (int i = 2; i <= broj / 2; i++)
            {
                if (broj % i == 0) return false;
            }
            return true;
        }

        static void Main()
        {
            int brojPrimBrojeva = 0;

            for (int i = 2; i < 100; i++)
            {
                if (JeProst(i))
                {
                    brojPrimBrojeva++;
                }
            }

            Console.WriteLine("Broj prostih brojeva manjih od 100 je: " + brojPrimBrojeva);
        }
    }
}


