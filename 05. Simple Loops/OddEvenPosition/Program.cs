using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

                    
            for (int i = 1; i <= num; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currentNumber;

                    if (evenMax < currentNumber)
                        evenMax = currentNumber;
                   
                    if (evenMin > currentNumber)
                        evenMin = currentNumber;
                }
                else
                {
                    oddSum += currentNumber;

                    if (oddMax < currentNumber)
                        oddMax = currentNumber;

                    if (oddMin > currentNumber)
                        oddMin = currentNumber;
                }
                                
            }
            if (num == 0)
            {
                Console.WriteLine("Oddsum = 0, Oddmin = No, Oddmax = No, " +
                    "Evensum = 0, Evenmin = no, Evenmax = no");
            }
            else if (num == 1)
            {
                               
                Console.WriteLine("Oddsum = {0}, Oddmin = {1}, Oddmax = {2}, " +
                    "Evensum = 0, Evenmin = no, Evenmax = no", oddSum, oddMin, oddMax);
            }
            else if (num != 0 && num != 1)
            Console.WriteLine("Oddsum = {0}, Oddmin = {1}, Oddmax = {2}, " +
                "Evensum = {3}, Evenmin = {4}, Evenmax = {5}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
        }
    }
}
