using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal smallestRoomArea = decimal.Parse(Console.ReadLine());
            decimal kitchenArea = decimal.Parse(Console.ReadLine());
            decimal pricePerKvM = decimal.Parse(Console.ReadLine());

            decimal bathroomArea = smallestRoomArea / 2;
            decimal secondRoomArea = smallestRoomArea * 1.10M;
            decimal thirdRoomArea = secondRoomArea * 1.10M;
            decimal houseArea = (smallestRoomArea + kitchenArea + bathroomArea + secondRoomArea + thirdRoomArea) * 1.05M;
            decimal housePrice = houseArea * pricePerKvM;

            Console.WriteLine($"{housePrice:f2}");
        }
    }
}
