using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                     

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - i - 1));
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int i = n - 2; i >= 0; i--)
            {
                Console.Write(new string(' ', n - i - 1));
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }
               
                Console.WriteLine();
            }            
        }
    }
}
