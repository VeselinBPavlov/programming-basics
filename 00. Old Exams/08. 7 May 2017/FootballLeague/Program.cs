using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadiumSeats = double.Parse(Console.ReadLine());
            double fans = double.Parse(Console.ReadLine());

            double fansSectorA = 0;
            double fansSectorB = 0;
            double fansSectorV = 0;
            double fansSectorG = 0;

            for (int i = 1; i <= fans; i++)
            {
                string sector = Console.ReadLine().ToLower();

                if (sector == "a")
                    fansSectorA++;
                else if (sector == "b")
                    fansSectorB++;
                else if (sector == "v")
                    fansSectorV++;
                else if (sector == "g")
                    fansSectorG++;
            }

            double fansAPer = (fansSectorA / fans) * 100;
            double fansBPer = (fansSectorB / fans) * 100;
            double fansVPer = (fansSectorV / fans) * 100;
            double fansGPer = (fansSectorG / fans) * 100;
            double fansPer = (fans / stadiumSeats) * 100;

            Console.WriteLine("{0:f2}%", fansAPer);
            Console.WriteLine("{0:f2}%", fansBPer);
            Console.WriteLine("{0:f2}%", fansVPer);
            Console.WriteLine("{0:f2}%", fansGPer);
            Console.WriteLine("{0:f2}%", fansPer);

        }
    }
}
