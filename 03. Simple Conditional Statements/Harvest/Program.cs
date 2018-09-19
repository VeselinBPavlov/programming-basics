using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int areaLoze = int.Parse(Console.ReadLine());
            double grozdekvm = double.Parse(Console.ReadLine());
            int needWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double areaVino = areaLoze * 0.4;
            double dobiv = areaVino * grozdekvm;
            double vine = (dobiv / 2.5);
            double prodajba = Math.Abs(needWine - vine);

            if (vine > prodajba)
            {
                double vineNeed = prodajba - vine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(vineNeed)} liters wine needed");
            }
            else
            {
                double vineLeft = vine - prodajba;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vine)} liters.");
                Console.WriteLine($"{Math.Ceiling(vineLeft)} liters left -> {Math.Ceiling(vineLeft/workers)} liters per person");
            }

        }
    }
}
