using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal chrysanthemums = decimal.Parse(Console.ReadLine());
            decimal roses = decimal.Parse(Console.ReadLine());
            decimal tulips = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string hollyday = Console.ReadLine().ToLower();
           
            decimal priceChrysantemums = 0.00M;
            decimal priceRoses = 0.00M;
            decimal priceTulips = 0.00M;
            decimal priceBouquet = 0.00M;


            if (season == "spring" || season == "summer")
            {
                priceChrysantemums = 2.00M;
                priceRoses = 4.10M;
                priceTulips = 2.50M;
            }
            else if (season == "autumn" || season =="winter")
            {
                priceChrysantemums = 3.75M;
                priceRoses = 4.50M;
                priceTulips = 4.15M;
            }

            if (hollyday == "y")
            {
                priceChrysantemums += priceChrysantemums * 0.15M;
                priceRoses += priceRoses * 0.15M;
                priceTulips += priceTulips * 0.15M;
            }

            priceBouquet = (chrysanthemums * priceChrysantemums) + (roses * priceRoses) + (tulips * priceTulips);

            if (tulips > 7 && season == "spring")
                priceBouquet -= priceBouquet * 0.05M;
            if (roses >= 10 && season == "winter")
                priceBouquet -= priceBouquet * 0.10M;
            if ((chrysanthemums + roses + tulips) > 20)
                priceBouquet -= priceBouquet * 0.20M;

            decimal sumBouquet = priceBouquet + 2.00M;

            Console.WriteLine($"{sumBouquet:f2}");
        }
    }
}
