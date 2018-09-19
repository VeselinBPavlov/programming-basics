using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal record = decimal.Parse(Console.ReadLine());
            decimal distance = decimal.Parse(Console.ReadLine());
            decimal timeSwimmingMeter = decimal.Parse(Console.ReadLine());

            decimal timeAllDistance = distance * timeSwimmingMeter;
            decimal slowingMeter = Math.Floor(distance / 15M);
            decimal slowing = slowingMeter * 12.5M;
            decimal time = timeAllDistance + slowing;

            if (time < record)
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", time);
            else
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", time - record);

        }
    }
}
