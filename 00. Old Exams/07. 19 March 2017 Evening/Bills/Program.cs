using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal mounths = decimal.Parse(Console.ReadLine());


            decimal allelectricity = 0.00M;
            for (int i = 0; i < mounths; i++)
            {
                decimal electricityBill = decimal.Parse(Console.ReadLine());
                allelectricity += electricityBill;
            }

            decimal waterBill = 20.00M;
            decimal internetBill = 15.00M;
            decimal comunalCosts = allelectricity + (waterBill * mounths) + (internetBill * mounths);
            decimal otherCosts = comunalCosts + (comunalCosts * 0.20M);
            decimal allCosts = otherCosts + comunalCosts;

            Console.WriteLine("Electricity: {0:f2} lv", allelectricity);
            Console.WriteLine("Water: {0:f2} lv", waterBill * mounths);
            Console.WriteLine("Internet: {0:f2} lv", internetBill * mounths);
            Console.WriteLine("Other: {0:f2} lv", (otherCosts * mounths) / mounths);
            Console.WriteLine("Average: {0:f2} lv", allCosts / mounths);
        }
    }
}
