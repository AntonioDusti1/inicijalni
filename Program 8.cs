using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicijalni
{
    class Program
    {
        static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main()
        {
            Console.WriteLine("Unesite broj n za izračun n-tog člana Fibonaccijevog niza: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + "-ti član Fibonaccijevog niza je: " + Fibonacci(n));
        }
    }
}


