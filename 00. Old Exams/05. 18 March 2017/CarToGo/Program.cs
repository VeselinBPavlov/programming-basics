using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string typeClass = "";
            string type = "";
            decimal sum = 0.00M;

            if (budget <= 100)
            {
                typeClass = "Economy class";
                switch (season)
                {
                    case "summer": type = "Cabrio"; sum = budget * 0.35M; break;
                    case "winter": type = "Jeep"; sum = budget * 0.65M; break;
                }
            }

            else if (budget > 100 && budget <= 500)
            {
                typeClass = "Compact class";
                switch (season)
                {
                    case "summer": type = "Cabrio"; sum = budget * 0.45M; break;
                    case "winter": type = "Jeep"; sum = budget * 0.80M; break;
                }
            }

            else if (budget > 500)
            {
                typeClass = "Luxury class";
                type = "Jeep"; sum = budget * 0.90M;         
            }

            Console.WriteLine(typeClass);
            Console.WriteLine($"{type} - {sum:f2}");
        }
    }
}
