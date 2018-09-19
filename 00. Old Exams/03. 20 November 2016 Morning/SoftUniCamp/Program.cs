using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            double peopleCar = 0;
            double peopleMicrobus = 0;
            double peopleSmallBus = 0;
            double peopleBigBus = 0;
            double peopleTrain = 0;
            double peopleAll = 0;

            for (int i = 0; i < groups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                peopleAll += people;

                if (people <= 5)                
                    peopleCar += people;
                if (people >= 6 && people <= 12)
                    peopleMicrobus += people;
                if (people >= 13 && people <= 25)
                    peopleSmallBus += people;
                if (people >= 26 && people <= 40)
                    peopleBigBus += people;
                if (people >= 41)
                    peopleTrain += people;
            }

            double perCar = (peopleCar / peopleAll) * 100;
            double perMicro = (peopleMicrobus / peopleAll) * 100;
            double perSmallBus = (peopleSmallBus / peopleAll) * 100;
            double perBigBus = (peopleBigBus / peopleAll) * 100;
            double perTrain = (peopleTrain / peopleAll) * 100;

            Console.WriteLine("{0:f2}%", perCar);
            Console.WriteLine("{0:f2}%", perMicro);
            Console.WriteLine("{0:f2}%", perSmallBus);
            Console.WriteLine("{0:f2}%", perBigBus);
            Console.WriteLine("{0:f2}%", perTrain);
        }
    }
}
