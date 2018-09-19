using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal whiskey = decimal.Parse(Console.ReadLine());
            decimal beerLiters = decimal.Parse(Console.ReadLine());
            decimal wineLiters = decimal.Parse(Console.ReadLine());
            decimal rakiaLiters = decimal.Parse(Console.ReadLine());
            decimal whiskeyLiters = decimal.Parse(Console.ReadLine());

            decimal rakia = whiskey * 0.50M;
            decimal wine = rakia  - (rakia *  0.40M);
            decimal beer = rakia - (rakia * 0.80M);

            decimal whiskeySum = whiskey * whiskeyLiters;
            decimal beerSum = beer * beerLiters;
            decimal wineSum = wine * wineLiters;
            decimal rakiaSum = rakia * rakiaLiters;

            decimal sum = whiskeySum + beerSum + wineSum + rakiaSum;

            Console.WriteLine("{0:f2}", sum);
        }
    }
}
