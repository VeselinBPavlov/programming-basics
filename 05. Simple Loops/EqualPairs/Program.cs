using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int doubles = int.Parse(Console.ReadLine());

            int sum = 0;
            int lastSum = 0;
            int counter = 0;
            int maxDifference = 1;

            for (int i = 1; i <= doubles; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                sum = a + b;

                if (sum == lastSum)
                {
                    counter++;
                }
                if (maxDifference < Math.Abs(lastSum - sum) && i >= 2)
                {
                    maxDifference = (Math.Abs(lastSum - sum));
                }
                if (sum != lastSum)
                {
                    lastSum = sum;
                }
            }
            if (counter == doubles - 1)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDifference);
            }
        }
    }
}
