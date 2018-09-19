using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var length = 3 * n;
            var widgth = 2 * n + 8;

            Console.WriteLine("{0}x{0}", new string('.', length / 2));
            Console.WriteLine("{0}/x\\{0}", new string('.', (length / 2) - 1));
            Console.WriteLine("{0}x|x{0}", new string('.', (length / 2) - 1));

            for (int i = 0; i < (n / 2); i++)
            {
                Console.Write("{0}{1}|{1}{0}", new string('.', (n / 2) - i), new string('x', n + i));
                Console.WriteLine();
            }

            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.Write("{0}{1}|{1}{0}", new string('.', i), new string('x', (length / 2) - i));
                Console.WriteLine();
            }

            Console.WriteLine("{0}/x\\{0}", new string('.', (length / 2) - 1));
            Console.WriteLine("{0}\\x/{0}", new string('.', (length / 2) - 1));

            for (int i = 0; i < (n / 2); i++)
            {
                Console.Write("{0}{1}|{1}{0}", new string('.', (n / 2) - i), new string('x', n + i));
                Console.WriteLine();
            }

            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.Write("{0}{1}|{1}{0}", new string('.', i), new string('x', (length / 2) - i));
                Console.WriteLine();
            }

            Console.WriteLine("{0}x|x{0}", new string('.', (length / 2) - 1));
            Console.WriteLine("{0}\\x/{0}", new string('.', (length / 2) - 1));
            Console.WriteLine("{0}x{0}", new string('.', length / 2));           
            
        }
    }
}
