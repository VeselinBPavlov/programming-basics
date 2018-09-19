using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int widgth = (2 * n) + 1;

            Console.WriteLine(new string('*', widgth));
            Console.WriteLine(".*{0}*.", new string(' ', widgth - 4));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i + 2), new string('@', (widgth - 2) - 2 * (i + 2)));
            }

            Console.WriteLine("{0}*{0}", new string('.', n));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', (n - 1) - i), new string(' ', i));
            }

            Console.WriteLine(".*{0}*.", new string('@', widgth - 4));
            Console.WriteLine(new string('*', widgth));
        }
    }
}
