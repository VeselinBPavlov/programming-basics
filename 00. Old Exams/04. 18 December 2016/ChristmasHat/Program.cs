using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int wigth = (4 * n) + 1;
            int heigth = (2 * n) + 5;

            Console.WriteLine("{0}/|\\{0}", new string('.', (wigth / 2) - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', (wigth / 2) - 1));

            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', ((n * 2) - 1) - i), new string('-', i));
            }

            Console.WriteLine(new string('*', wigth));
            for (int i = 0; i < (wigth / 2); i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");            
            Console.WriteLine(new string('*', wigth));
        }
    }
}
