using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tripPrice = decimal.Parse(Console.ReadLine());
            decimal puzzles = decimal.Parse(Console.ReadLine());
            decimal dolls = decimal.Parse(Console.ReadLine());
            decimal bears = decimal.Parse(Console.ReadLine());
            decimal minions = decimal.Parse(Console.ReadLine());
            decimal trucks = decimal.Parse(Console.ReadLine());

            decimal puzzlesSum = puzzles * 2.60M;
            decimal dollsSum = dolls * 3.00M;
            decimal bearsSum = bears * 4.10M;
            decimal minionSum = minions * 8.20M;
            decimal truckSum = trucks * 2.00M;

            decimal sumToys = puzzles + dolls + bears + minions + trucks;
            decimal sumAll = puzzlesSum + dollsSum + bearsSum + minionSum + truckSum;

            if (sumToys >= 50)
                sumAll = sumAll - (sumAll * 0.25M);

            decimal sum = sumAll - (sumAll * 0.10M);
            

            if (sum >= tripPrice)
                Console.WriteLine("Yes! {0:f2} lv left.", sum - tripPrice);
            else
                Console.WriteLine("Not enough money! {0:f2} lv needed.", tripPrice - sum);
        }
    }
}
