using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var currentNum = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (currentNum <= n)
                    {
                        Console.Write("{0} ", currentNum);
                        currentNum++;
                    }
                    else
                        break;                                      
                }
                Console.WriteLine();                
            }
        }
    }
}
