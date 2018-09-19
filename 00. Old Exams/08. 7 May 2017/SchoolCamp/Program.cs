using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string grup = Console.ReadLine().ToLower();
            decimal students = decimal.Parse(Console.ReadLine());
            decimal nights = decimal.Parse(Console.ReadLine());

            decimal pricePerNight = 0.00M;
            string sport = null;

            if (grup == "boys" || grup == "girls")
            {
                switch(season)
                {
                    case "winter": pricePerNight += 9.60M; break;
                    case "spring": pricePerNight += 7.20M; break;
                    case "summer": pricePerNight += 15.00M; break;
                }
            }
            else
            {
                switch (season)
                {
                    case "winter": pricePerNight += 10.00M; break;
                    case "spring": pricePerNight += 9.50M; break;
                    case "summer": pricePerNight += 20.00M; break;
                }
            }

            decimal priceAll = students * nights * pricePerNight;

            if (students >= 50)
                priceAll -= priceAll * 0.50M;
            else if (students >= 20 && students < 50)
                priceAll -= priceAll * 0.15M;
            else if (students >= 10 && students < 20)
                priceAll -= priceAll * 0.05M;

            if (grup == "boys")
            {
                switch (season)
                {
                    case "winter": sport = "Judo"; break;
                    case "spring": sport = "Tennis"; break;
                    case "summer": sport = "Football"; break;
                }
            }
            else if (grup == "girls")
            {
                switch (season)
                {
                    case "winter": sport = "Gymnastics"; break;
                    case "spring": sport = "Athletics"; break;
                    case "summer": sport = "Volleyball"; break;
                }
            }
            else if (grup == "mixed")
            {
                switch (season)
                {
                    case "winter": sport = "Ski"; break;
                    case "spring": sport = "Cycling"; break;
                    case "summer": sport = "Swimming"; break;
                }
            }

            Console.WriteLine("{0} {1:f2} lv.", sport, priceAll);
        }
    }
}
