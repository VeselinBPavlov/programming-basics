using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int length = n * 5;

            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', (n * 2) + 1));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', n - i), new string('_', ((n * 2)  - 1) + (i + i)));
            }

            Console.WriteLine("//{0}STOP!{0}\\\\",  new string('_', (n * 2) - 3));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', i), new string('_', ((n * 4) - 1) - (i + i)));
            }
        }
    }
}
