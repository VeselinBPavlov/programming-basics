using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int wigth = (2 * n) - 1;
            double heigth = (n / 2) + 4;

            int points = 0;

            Console.WriteLine("@{0}@{0}@", new string(' ', n - 2));
            Console.WriteLine("**{0}*{0}**", new string(' ', n - 3));

            for (int i = 1; i < (n / 2) - 1; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', i), new string(' ', (n - 3) - (i + i)), new string('.',  i + points));
                points++;
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', (n / 2) - 1), new string('.', n - 3));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n / 2), new string('*', (n / 2) - 2));
            Console.WriteLine("{0}", new string('*', wigth));
            Console.WriteLine("{0}", new string('*', wigth));
        }
    }
}
