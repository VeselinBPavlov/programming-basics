using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic
{
    class Program
    {
        static void Main(string[] args)
        {
            int freight = int.Parse(Console.ReadLine());

            double microbusPrice = 200;
            double truckPrice = 175;
            double trainPrice = 120;

            double microbusTon = 0;
            double truckTon = 0;
            double trainTon = 0;
            double tons = 0;
            double microbusPer = 0;
            double truckPer = 0;
            double trainPer = 0;

            double sumTonsAverage = 0;
            double microbusSum = 0;
            double truckSum = 0;
            double trainSum = 0;


            for (int i = 0; i < freight; i++)
            {
                int tonPerFreight = int.Parse(Console.ReadLine());

                if (tonPerFreight <= 3)
                    microbusTon += tonPerFreight;
                else if (tonPerFreight > 3 && tonPerFreight <= 11)
                    truckTon += tonPerFreight;
                else if (tonPerFreight > 11)
                    trainTon += tonPerFreight;
            }

            tons = microbusTon + truckTon + trainTon;
            microbusPer = microbusTon / tons * 100;
            truckPer = truckTon / tons * 100;
            trainPer = trainTon / tons * 100;

            microbusSum = microbusTon * microbusPrice;
            truckSum = truckTon * truckPrice;
            trainSum = trainTon * trainPrice;
            sumTonsAverage = (microbusSum + truckSum + trainSum) / tons;

            

            Console.WriteLine("{0:f2}", sumTonsAverage);
            Console.WriteLine("{0:f2}%", microbusPer);
            Console.WriteLine("{0:f2}%", truckPer);
            Console.WriteLine("{0:f2}%", trainPer);

        }
    }
}
