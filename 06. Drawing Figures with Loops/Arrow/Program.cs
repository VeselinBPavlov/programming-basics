using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var length = n + ((n / 2) * 2);
            var heigth = n + ((n / 2) * 2);

            for (int i = 0; i < n - 1; i++)
            {
                if (i == 0)
                {
                    Console.Write("{0}{1}{0}", new string('.', n / 2), new string('#', n));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("{0}#{1}#{0}", new string('.', n / 2), new string('.', n - 2));
                    Console.WriteLine();
                }
            }

            Console.Write("{0}{1}{0}", new string('#', (n / 2) + 1), new string('.', n - 2));
            Console.WriteLine();

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("{0}#{1}#{0}", new string('.', i + 1), new string('.', (length - 4) - (i + i)));
                Console.WriteLine();
            }

            Console.Write("{0}#{0}", new string('.', n - 1));
            Console.WriteLine();
        }
    }
}
