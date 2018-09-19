using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal houseArea = decimal.Parse(Console.ReadLine());
            decimal windows = decimal.Parse(Console.ReadLine());
            decimal steroporPack = decimal.Parse(Console.ReadLine());
            decimal priceSteroPack = decimal.Parse(Console.ReadLine());

            decimal netHouseArea = houseArea - (windows * 2.4M);
            decimal needStero = netHouseArea + (netHouseArea * 0.1M);
            decimal needPacks = Math.Ceiling (needStero / steroporPack);
            decimal sum = needPacks * priceSteroPack;

            if (sum <= budget)
            {
                Console.WriteLine("Spent: {0:f2}", sum);
                Console.WriteLine("Left: {0:f2}", budget - sum);
            }
            else
                Console.WriteLine("Need more: {0:f2}", sum - budget);
        }
    }
}
