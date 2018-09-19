using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var length = 2 * n + 1;
            var widgth = 2 * n + 3;

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', n - i));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n - 1), new string('*', 5));
            Console.WriteLine("{0}", new string('*', widgth));
            Console.WriteLine("{0}{1}{0}", new string('.', n - 1), new string('*', 5));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', n - 2 - i), new string('.', 2 + i));
            }
        }
    }
}
