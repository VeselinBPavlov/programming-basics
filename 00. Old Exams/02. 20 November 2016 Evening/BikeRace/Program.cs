using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal juniorBykers = decimal.Parse(Console.ReadLine());
            decimal seniorsBykers = decimal.Parse(Console.ReadLine());
            string trace = Console.ReadLine().ToLower();

            decimal taxJunior = 0.00M;
            decimal taxSenior = 0.00M;
            decimal allTax = 0.00M;

            switch (trace)
            {
                case "trail": taxJunior = 5.50M; taxSenior = 7.00M; break;
                case "cross-country": taxJunior = 8.00M; taxSenior = 9.50M; break;
                case "downhill": taxJunior = 12.25M; taxSenior = 13.75M; break;
                case "road": taxJunior = 20.00M; taxSenior = 21.50M; break;
            }

            allTax = (juniorBykers * taxJunior) + (seniorsBykers * taxSenior);

            if (trace == "cross-country" && (juniorBykers + seniorsBykers) >= 50)
            {
                allTax -= allTax * 0.25M;                
            }

            allTax -= allTax * 0.05M;

            Console.WriteLine($"{allTax:f2}");
        }
    }
}
