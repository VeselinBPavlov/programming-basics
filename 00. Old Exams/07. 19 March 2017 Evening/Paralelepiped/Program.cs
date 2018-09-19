using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int wigth = (3 * n) + 1;
            int heigth = (4 * n) + 4;

            Console.WriteLine("+{0}+{1}", new string('~', n - 2), new string('.', (n * 2) + 1));

            for (int i = 0; i <= (n * 2); i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', i), new string('~', (n - 2)), new string('.', (n * 2) - i));
            }
            for (int i = 0; i <= (n * 2); i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', i), new string('.', (n * 2) - i), new string('~', (n - 2)));
            }
            
            Console.WriteLine("{0}+{1}+", new string('.', (n * 2) + 1), new string('~', n -2));
        }
    }
}
