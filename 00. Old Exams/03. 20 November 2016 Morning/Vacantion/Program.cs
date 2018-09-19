using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal oldPearsons = decimal.Parse(Console.ReadLine());
            decimal students = decimal.Parse(Console.ReadLine());
            decimal nights = decimal.Parse(Console.ReadLine());
            string typeTransport = Console.ReadLine().ToLower();

            decimal priceOld = 0.00M;
            decimal priceStudents = 0.00M;

            switch (typeTransport)
            {
                case "train": priceOld = 24.99M; priceStudents = 14.99M; break;
                case "bus": priceOld = 32.50M; priceStudents = 28.50M; break;
                case "boat": priceOld = 42.99M; priceStudents = 39.99M; break;
                case "airplane": priceOld = 70.00M; priceStudents = 50.00M; break;
            }

            if ((oldPearsons + students) >= 50 && typeTransport == "train")
            {
                priceOld -= priceOld * 0.5M;
                priceStudents -= priceStudents * 0.5M;
            }

            decimal sumTransport = ((oldPearsons * priceOld) + (students * priceStudents)) * 2;
            decimal sumHotel = nights * 82.99M;
            decimal sumCommision = (sumHotel + sumTransport) * 0.10M;
            decimal sum = sumHotel + sumTransport + sumCommision;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
