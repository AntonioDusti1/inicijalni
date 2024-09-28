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
          
            Console.WriteLine("Unesite niz znakova: ");
            string tekst = Console.ReadLine();

            
            string zamijenjeniTekst = tekst.Replace(' ', '_');

            
            Console.WriteLine("Zamijenjeni niz: " + zamijenjeniTekst);
        }
    }
}


