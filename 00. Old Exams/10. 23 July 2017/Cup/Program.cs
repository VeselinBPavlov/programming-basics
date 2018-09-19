using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var length = 5 * n;

            for (int i = 0; i <= n + 1; i++)
            {
                if (i + 1 <= n / 2)
                {
                    Console.Write("{0}{1}{0}", new string('.', n + i), new string('#', (n * 3) - (i + i)));
                }
                else if (i == n + 1)
                {
                    Console.Write("{0}{1}{0}", new string('.', (n + i) - 1), new string('#', n));
                }
                else
                    Console.Write("{0}#{1}#{0}", new string('.', n + i), new string('.', (n * 3) - (i + i) - 2));

                Console.WriteLine();
            }

            for (int i = 0; i < n + 2; i++)
            {
                if (i == n / 2)
                {
                    Console.Write("{0}D^A^N^C^E^{0}", new string('.', (length - 10) / 2));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("{0}{1}{0}", new string('.', (n * 2) - 2), new string('#', n + 4));
                    Console.WriteLine();
                }
            }
        }
    }
}
