using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal priceScumria = decimal.Parse(Console.ReadLine());
            decimal priceCaca = decimal.Parse(Console.ReadLine());
            decimal kgPalamud = decimal.Parse(Console.ReadLine());
            decimal kgSafrid = decimal.Parse(Console.ReadLine());
            decimal kgMidi = decimal.Parse(Console.ReadLine());

            decimal pricePalamud = priceScumria + (priceScumria * 0.6M);
            decimal priceSafrid = priceCaca + (priceCaca * 0.8M);
            decimal priceMidi = 7.50M;

            decimal sum = (kgPalamud * pricePalamud) + (kgSafrid * priceSafrid) + (kgMidi * priceMidi);

            Console.WriteLine($"{sum:f2}");
        }
    }
}
