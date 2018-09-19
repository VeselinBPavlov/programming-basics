using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacancion
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string place = "";
            string destinacion = "";
            decimal sum = 0.00M;

            if (budget <= 1000)
            {
                place = "Camp";
                switch (season)
                {
                    case "summer": destinacion = "Alaska"; sum = budget * 0.65M; break;
                    case "winter": destinacion = "Morocco"; sum = budget * 0.45M; break;
                }
            }
            if (budget > 1000 && budget <= 3000)
            {
                place = "Hut";
                switch (season)
                {
                    case "summer": destinacion = "Alaska"; sum = budget * 0.8M; break;
                    case "winter": destinacion = "Morocco"; sum = budget * 0.6M; break;
                }
            }
            if (budget > 3000)
            {
                place = "Hotel";
                switch (season)
                {
                    case "summer": destinacion = "Alaska"; sum = budget * 0.9M; break;
                    case "winter": destinacion = "Morocco"; sum = budget * 0.9M; break;
                }
            }

            Console.WriteLine("{0} - {1} - {2:f2}", destinacion, place, sum);

        }
    }
}
