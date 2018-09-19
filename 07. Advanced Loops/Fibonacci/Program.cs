using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fib1 = 1;
            int fib2 = 1;

            for (int i = 0; i < n - 1; i++)
            {
                var currentFib = fib1 + fib2;
                fib1 = fib2;
                fib2 = currentFib;
            }
            Console.WriteLine(fib2);
        }
    }
}
