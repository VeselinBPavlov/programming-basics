using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combinations = 0;

            for (int i = begin; i <= end; i++)
            {
                for (int j = begin; j <= end; j++)
                {
                    combinations++;
                    if ((i + j) == magicNum)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", combinations, i, j, magicNum);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}", combinations, magicNum);
        }
    }
}
