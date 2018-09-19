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
            int restingDays = int.Parse(Console.ReadLine());

            int workingDays = 365 - restingDays;
            int realTimePlay = (workingDays * 63) + (restingDays * 127);
                  
            if (realTimePlay <= 30000)
            {
                int timeToPlay = 3000 - realTimePlay;
                int hours = timeToPlay / 60;
                int minutes = timeToPlay % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less to play");
                
            }
            else
            {
                int timeToPlay = realTimePlay - 30000;
                int hours = timeToPlay / 60;
                int minutes = timeToPlay % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }

        }
    }
}
