using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int turns = int.Parse(Console.ReadLine());

            decimal result = 0;
            decimal nums0to9 = 0;
            decimal nums10to20 = 0;
            decimal nums20to30 = 0;
            decimal nums30to40 = 0;
            decimal nums40to50 = 0;
            decimal numsnon = 0;        

            for (int i = 0; i < turns; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());

                if (num < 0 || num > 50)
                {
                    numsnon += 1;
                    result /= 2;
                }
                else if (num >= 0 && num <= 9)
                {
                    result += (num * 0.2M);
                    nums0to9++;
                }
                else if (num >= 10 && num <= 19)
                {
                    result += (num * 0.3M);
                    nums10to20++;
                }
                else if (num >= 20 && num <= 29)
                {
                    result += (num * 0.4M);
                    nums20to30++;
                }
                else if (num >= 30 && num <= 39)
                {
                    result += 50;
                    nums30to40++;
                }
                else if (num >= 40 && num <= 50)
                {
                    result += 100;
                    nums40to50++;
                }
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine("From 0 to 9: {0:f2}%", (nums0to9 / turns) * 100);
            Console.WriteLine("From 10 to 19: {0:f2}%", (nums10to20 / turns) * 100);
            Console.WriteLine("From 20 to 29: {0:f2}%", (nums20to30 / turns) * 100);
            Console.WriteLine("From 30 to 39: {0:f2}%", (nums30to40 / turns) * 100);
            Console.WriteLine("From 40 to 50: {0:f2}%", (nums40to50 / turns) * 100);
            Console.WriteLine("Invalid numbers: {0:f2}%", (numsnon / turns) * 100);
        }
    }
}
