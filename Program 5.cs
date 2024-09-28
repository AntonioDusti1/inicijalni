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
            Console.WriteLine("Unesite URL adresu: ");
            string url = Console.ReadLine();

            if (url.StartsWith("www") && url.EndsWith("hr") && url.Contains('.'))
            {
                Console.WriteLine("URL je ispravan.");
            }
            else
            {
                Console.WriteLine("URL nije ispravan.");
            }
        }
    }
}


