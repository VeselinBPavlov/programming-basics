using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double loads = double.Parse(Console.ReadLine());

            double loadsTruck = 0;
            double loadsMicrobus = 0;
            double loadsTrain = 0;
            double priceLoad = 0;
            double allTons = 0;
            double averagePrice = 0;

            for (int i = 0; i < loads; i++)
            {
                int tons = int.Parse(Console.ReadLine());

                if (tons <= 3)
                {
                    loadsMicrobus += tons;
                    allTons += tons;
                    priceLoad += (tons * 200);
                }
                else if (tons >= 4 && tons <= 11)
                {
                    loadsTruck += tons;
                    allTons += tons;
                    priceLoad += (tons * 175);
                }
                else if (tons >= 12)
                {
                    loadsTrain += tons;
                    allTons += tons;
                    priceLoad += (tons * 120);
                }
            }

            averagePrice = priceLoad / allTons;
            double perMicro = (loadsMicrobus / allTons) * 100;
            double perTruck = (loadsTruck / allTons) * 100;
            double perTrain = (loadsTrain / allTons) * 100;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{perMicro:f2}%");
            Console.WriteLine($"{perTruck:f2}%");
            Console.WriteLine($"{perTrain:f2}%");
        }
    }
}
