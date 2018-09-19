using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavorizingCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal days = decimal.Parse(Console.ReadLine());
            decimal sweetCookers = decimal.Parse(Console.ReadLine());
            decimal cakes = decimal.Parse(Console.ReadLine());
            decimal wafers = decimal.Parse(Console.ReadLine());
            decimal pancakes = decimal.Parse(Console.ReadLine());
            

            decimal sumCakes = cakes * 45M;
            decimal sumWafers = wafers * 5.80M;
            decimal sumPancakes = pancakes * 3.20M;
            decimal sumDay = (sumCakes + sumWafers + sumPancakes) * sweetCookers;
            decimal sumAllCampaign = sumDay * days;

            decimal costs = sumAllCampaign * 0.125M;

            decimal darenie = sumAllCampaign - costs;           

            Console.WriteLine("{0:f2}", darenie);
        }
    }
}
