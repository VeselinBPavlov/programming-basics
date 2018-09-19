using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combinations = 0;

            for (int i = begin; i >= end; i--)
            {
                for (int j = begin; j >= end; j--)
                {
                    combinations++;
                    if ((i + j) == magicNumber)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", combinations, i, j, magicNumber);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}", combinations, magicNumber);
        }
    }
}
