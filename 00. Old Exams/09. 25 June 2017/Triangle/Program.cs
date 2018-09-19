using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var length = (4 * n) + 1;
            var heigth = (2 * n) + 1;

            var spaces = 0;

            Console.WriteLine("{0}", new string('#', length));

            for (int i = 1; i <= n; i++)
            {
                if (i == (n / 2) + 1)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', (n / 2) + 1), new string('#', n - 1), new string(' ', (n / 2) - 1));
                        spaces += 2;
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', (n / 2) + 1), new string('#', n), new string(' ', (n / 2) - 1));
                        spaces += 2;
                    }
                                     
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), new string('#', ((n * 2) - 1) - spaces), new string(' ', (i * 2) - 1));
                    spaces += 2;
                }
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (n + 1) + i), new string('#', ((n * 2) - 1) - i * 2));
            }
        }
    }
}
