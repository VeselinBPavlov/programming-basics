using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)

            {
                Console.WriteLine("{0}**{0}", new string('-', (n / 2) - 1));
                for (int i = 0; i < (n - 1) / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', ((n - 2) / 2) - (i + 1)), new string('-', (2 + i + i)));    
                }
                for (int i = 0; i < (n / 2) - 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', 1 + i), new string('-', (n - 4) - (i + i)));
                }
                Console.WriteLine("{0}**{0}", new string('-', (n / 2) - 1));
            }
            else
            {
                Console.WriteLine("{0}*{0}", new string('-', (n / 2)));
                for (int i = 0; i < (n / 2); i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', ((n / 2) - 1) - i), new string('-', 1 + (i + i)));
                }
                for (int i = 0; i < (n / 2) - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', 1 + i), new string('-', (n - 4) - (i + i)));
                }                
                Console.WriteLine("{0}*{0}", new string('-', (n / 2)));
            }
        }
    }
}