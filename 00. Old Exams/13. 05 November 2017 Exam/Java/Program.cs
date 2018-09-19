using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int wigth = (3 * n) + 6;
            int heigth = (3 * n) + 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}~ ~ ~", new string(' ', n));
            }
            Console.WriteLine(new string('=', wigth - 1));

            for (int i = 0; i < n - 2; i++)
            {
                if (i == (n / 2) - 1)
                    Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', n), new string(' ', n - 1));
                else
                    Console.WriteLine(("|{0}|{1}|"), new string('~', (n * 2) + 4), new string(' ', n - 1));
            }
            Console.WriteLine(new string('=', wigth - 1));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/", new string(' ', i), new string('@', ((n * 2) + 4) - (i + i)));               
            }
            Console.WriteLine(new string('=', (n * 2) + 6));
        }
    }
}
