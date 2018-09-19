using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            decimal sumStudio = 0.00M;
            decimal sumApartment = 0.00M;
            decimal endSumStudio = 0.00M;
            decimal endSumApartment = 0.00M;

            bool mayOctober = (month == "may" || month == "october");
            bool juneSeptember = (month == "june" || month == "september");
            bool julyAugust = (month == "july" || month == "august");

            if (mayOctober == true)
            {
                sumStudio = nights * 50.00M;
                sumApartment = nights * 65.00M;

                if (nights >= 7 && nights <= 14)
                {
                    endSumStudio = sumStudio - (sumStudio * 0.05M);
                    endSumApartment = sumApartment;
                }
                else
                {
                    endSumStudio = sumStudio - (sumStudio * 0.30M);
                    endSumApartment = sumApartment - (sumApartment * 0.10M);
                }
            }
            else if (juneSeptember == true)
            {
                sumStudio = nights * 75.20M;
                sumApartment = nights * 68.70M;

                if (nights > 14)
                {
                    endSumStudio = sumStudio - (sumStudio * 0.20M);
                    endSumApartment = sumApartment - (sumApartment * 0.10M);
                }
                else
                {
                    endSumStudio = sumStudio;
                    endSumApartment = sumApartment;
                }
            }
            else if (julyAugust == true)
            {
                sumStudio = nights * 76.00M;
                sumApartment = nights * 77.00M;

                if (nights > 14)
                {
                    endSumStudio = sumStudio;
                    endSumApartment = sumApartment - (sumApartment * 0.10M);
                }
                else
                {
                    endSumStudio = sumStudio;
                    endSumApartment = sumApartment;
                }

            }

           
           

            Console.WriteLine("Apartment: {0:F2} lv.", endSumApartment);
            Console.WriteLine("Studio: {0:f2} lv.", endSumStudio);

        }
    }
}
