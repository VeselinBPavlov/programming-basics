using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyBequest = decimal.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());

            decimal sum1 = 0.00M;
            decimal sum2 = 0.00M;
            int years = 18;
            decimal moneyNeed = 0.00M;

            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 += 12000;
                    years++;
                }
                else
                {
                    sum2 = sum2 + (12000 + (50 * years));
                    years++;
                }
            }
            moneyNeed = sum1 + sum2;
            if (moneyNeed <= moneyBequest)
                Console.WriteLine("Yes! He will live a carefree life " +
                    "and will have {0:f2} dollars left.", moneyBequest - moneyNeed);
            else
                Console.WriteLine("He will need {0:f2} dollars to survive.", moneyNeed - moneyBequest);
        }
    }
}
