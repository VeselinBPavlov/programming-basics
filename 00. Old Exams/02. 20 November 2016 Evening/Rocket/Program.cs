using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int widgth = 3 * n;            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', ((widgth / 2) - 1) - i), new string(' ', (i + i)));               
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', n * 2));

            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', (n * 2) - 2));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', (n / 2) - i), new string('*', ((widgth - n) - 2) + (i + i)));
            }
        }
    }
}
