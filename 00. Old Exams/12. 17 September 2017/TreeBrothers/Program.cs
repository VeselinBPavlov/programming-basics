using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeBrother1 = double.Parse(Console.ReadLine());
            double timeBrother2 = double.Parse(Console.ReadLine());
            double timeBrother3 = double.Parse(Console.ReadLine());
            double timeFishingFather = double.Parse(Console.ReadLine());

            double allTimeCleaning = 1 / (1 / timeBrother1 + 1 / timeBrother2 + 1 / timeBrother3);
            double cleningRest = (allTimeCleaning * 0.15) + allTimeCleaning;
            double timeSuprise = 0;

            Console.WriteLine("Cleaning time: {0:f2}", cleningRest);
            if (cleningRest < timeFishingFather)
            {
                timeSuprise = timeFishingFather - cleningRest;
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(timeSuprise));
            }
            else
            {
                timeSuprise = cleningRest - timeFishingFather;
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(timeSuprise));
            }
        }
    }
}
