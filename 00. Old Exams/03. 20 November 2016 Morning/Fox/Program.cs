using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int wigth = (2 * n) + 3;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', 1 + i), new string('-', (wigth - 4) - (i + i)));
            }
            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', (n / 2) + i), new string('*', n - (i + i)));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', 1 + i), new string('*', (wigth - 4) - (i + i)));
            }
        }
    }
}
