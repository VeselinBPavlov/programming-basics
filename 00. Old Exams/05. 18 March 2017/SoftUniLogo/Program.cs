using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int wigth = (12 * n) - 5;
            int heigth = (4 * n) - 2;
            

            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', ((wigth / 2)) - (i  * 3)), new string('#', 1 + (i * 3) + (i * 3)));
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', 2 + (i * 3)), new string('#', (wigth - 6) - ((i * 3) + (i * 3))), new string('.', 3 + (i * 3)));
            }
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', ((wigth / 2)) - ((n * 3) + 1)), new string('#', (n * 6) + 1), new string('.', ((wigth / 2)) - ((n * 3) + 1) + 1));
            }
            Console.WriteLine("@{0}{1}{2}", new string('.', ((wigth / 2)) - ((n * 3) + 1)), new string('#', (n * 6) + 1), new string('.', ((wigth / 2)) - ((n * 3) + 1) + 1));


        }
    }
}
