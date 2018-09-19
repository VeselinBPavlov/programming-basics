using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            double holliday = double.Parse(Console.ReadLine());

            double hoursHollyday = holliday * 127;
            double workDays = 365 - holliday;
            double hoursWork = workDays * 63;
            double allTime = hoursWork + hoursHollyday;

            if (30000 >= allTime)
            {
                Console.WriteLine("Tom sleeps well");
                double hours = (30000 - allTime) / 60;
                double minutes = (30000 - allTime) % 60;
                Console.WriteLine("{0} hours and {1} minutes less for play", Math.Floor(hours), minutes);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                double hours = (allTime - 30000) / 60;
                double minutes = (allTime - 30000) % 60;
                Console.WriteLine("{0} hours and {1} minutes more for play", Math.Floor(hours), minutes);
            }
        }
    }
}
