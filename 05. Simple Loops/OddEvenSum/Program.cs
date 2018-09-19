using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                    sumEven += currentNum;
                else 
                    sumOdd += currentNum;
            }
            if (sumEven == sumOdd)
                Console.WriteLine("Yes, sum = {0}", sumEven);
            else
                Console.WriteLine("No, diff = {0}", Math.Abs(sumEven - sumOdd)); 
        }
    }
}
