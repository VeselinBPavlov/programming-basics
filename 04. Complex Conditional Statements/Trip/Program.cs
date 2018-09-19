using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            double campBulgaria = budget * 0.30;
            double hotelBulgaria = budget * 0.70;
            double campBalcans = budget * 0.40;
            double hotelBalcans = budget * 0.80;
            double tripEurope = budget * 0.90;

            if (budget <= 100 && season == "summer")
            {
                Console.WriteLine("Somewhere in Bulgaria");
                Console.Write("Camp - ");
                Console.WriteLine("{0:f2}", campBulgaria);
            }
            else if (budget <= 100 && season == "winter")
            {
                Console.WriteLine("Somewhere in Bulgaria");
                Console.Write("Hotel - ");
                Console.WriteLine("{0:f2}", hotelBulgaria);
            }
            else if (budget > 100 && budget <= 1000 && season == "summer")
            {
                Console.WriteLine("Somewhere in Balkans");
                Console.Write("Camp - ");
                Console.WriteLine("{0:f2}", campBalcans);
            }
            else if (budget > 100 && budget <= 1000 && season == "winter")
            {
                Console.WriteLine("Somewhere in Balkans");
                Console.Write("Hotel - ");
                Console.WriteLine("{0:f2}", hotelBalcans);
            }
            else if (budget > 1000 && (season == "winter" || season == "summer"))
            {
                Console.WriteLine("Somewhere in Europe");
                Console.Write("Hotel - ");
                Console.WriteLine("{0:f2}", tripEurope);
            }

        }
    }
}
