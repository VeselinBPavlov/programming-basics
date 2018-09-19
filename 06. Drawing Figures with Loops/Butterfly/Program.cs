using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var length = (2 * n) - 1;
            var higth = 2 * (n - 2) + 1;

            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write("{0}\\ /{0}", new string('*', n - 2));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("{0}\\ /{0}", new string('-', n - 2));
                    Console.WriteLine();
                }
            }

            Console.Write("{0}@{0}", new string(' ', n - 1));
            Console.WriteLine();

            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write("{0}/ \\{0}", new string('*', n - 2));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("{0}/ \\{0}", new string('-', n - 2));
                    Console.WriteLine();
                }
            }
        }
    }
}
