using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double dogEat = double.Parse(Console.ReadLine());
            double catEat = double.Parse(Console.ReadLine());
            double turtleEat = double.Parse(Console.ReadLine());

            double needDog = dogEat * days;
            double needCat = catEat * days;
            double needTurtle = (turtleEat * days) / 1000;
            double allFoodNeed = needDog + needCat + needTurtle;

            if (food >= allFoodNeed)
                Console.WriteLine("{0} kilos of food left.", Math.Floor(food - allFoodNeed));
            else
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(allFoodNeed - food));
        }
    }
}
