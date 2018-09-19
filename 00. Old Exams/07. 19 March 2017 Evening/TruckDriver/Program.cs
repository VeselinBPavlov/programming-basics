using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            decimal kilometersByMonth = decimal.Parse(Console.ReadLine());

            decimal priceKm = 0.00M;

            if (kilometersByMonth <= 5000)
            {
                switch (season)
                {
                    case "spring": priceKm += 0.75M; break;
                    case "autumn": priceKm += 0.75M; break;
                    case "summer": priceKm += 0.90M; break;
                    case "winter": priceKm += 1.05M; break;
                }
            }
            else if (kilometersByMonth > 5000 && kilometersByMonth <= 10000)
            {
                switch (season)
                {
                    case "spring": priceKm += 0.95M; break;
                    case "autumn": priceKm += 0.95M; break;
                    case "summer": priceKm += 1.10M; break;
                    case "winter": priceKm += 1.25M; break;
                }
            }
            else if (kilometersByMonth > 10000 && kilometersByMonth <= 20000)
            {
                priceKm += 1.45M;
            }

            decimal grossMonthWage = kilometersByMonth * priceKm;
            decimal grossSeasonWage = grossMonthWage * 4;
            decimal netSeasonWage = grossSeasonWage - (grossSeasonWage * 0.10M);

            Console.WriteLine("{0:f2}", netSeasonWage);
        }
    }
}
