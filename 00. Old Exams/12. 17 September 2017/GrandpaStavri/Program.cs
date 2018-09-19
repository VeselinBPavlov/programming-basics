using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandpaStavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double sumQuantity = 0;
            double sumDegree = 0;
            double averageDegree = 0;         
            
            for (int i = 0; i < days; i++)
            {
                double quantityRakia = double.Parse(Console.ReadLine());
                double degreeRakia = double.Parse(Console.ReadLine());
                sumQuantity += quantityRakia;
                sumDegree += (degreeRakia * quantityRakia);
            }

            
            Console.WriteLine("Liter: {0:f2}", sumQuantity);
            Console.WriteLine("Degrees: {0:f2}", sumDegree / sumQuantity);
            if (sumDegree / sumQuantity < 38)
                Console.WriteLine("Not good, you should baking!");
            else if (sumDegree / sumQuantity >= 38 && sumDegree / sumQuantity <= 42)
                Console.WriteLine("Super!");
            else
                Console.WriteLine("Dilution with distilled water!");
        }
    }
}
