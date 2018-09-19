using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());
            decimal wigthFloor = decimal.Parse(Console.ReadLine());
            decimal lengthFloor = decimal.Parse(Console.ReadLine());
            decimal sideTriangle = decimal.Parse(Console.ReadLine());
            decimal higthTriangle = decimal.Parse(Console.ReadLine());
            decimal priceTile = decimal.Parse(Console.ReadLine());
            decimal sumMaistor = decimal.Parse(Console.ReadLine());

            decimal floorArea = wigthFloor * lengthFloor;
            decimal tileArea = (sideTriangle * higthTriangle) / 2;
            decimal needTile = Math.Ceiling(floorArea / tileArea) + 5;
            decimal sum = (needTile * priceTile) + sumMaistor;

            if (sum <= savings)
                Console.WriteLine("{0:f2} lv left.", savings - sum);
            else
                Console.WriteLine("You'll need {0:f2} lv more.", sum - savings);
        }
    }
}
