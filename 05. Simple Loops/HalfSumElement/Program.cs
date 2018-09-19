using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                int currnetNumber = int.Parse(Console.ReadLine());
                sum += currnetNumber;
                if (currnetNumber > max)
                    max = currnetNumber;                
            }
            if (max == (sum - max))
                Console.WriteLine("Yes, sum = {0}", max);
            else
                Console.WriteLine("No, diff = {0}", Math.Abs(max - (sum - max)));
        }
    }
}
