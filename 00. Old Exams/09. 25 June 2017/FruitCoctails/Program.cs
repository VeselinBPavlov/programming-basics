using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCoctails
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string sizeCoctail = Console.ReadLine().ToLower();
            decimal drinks = decimal.Parse(Console.ReadLine());

            decimal price = 0.00M;
            decimal sum = 0.00M;
            decimal sumAll = 0.00M;

            if (sizeCoctail == "small")
            {
                switch(fruit)
                {
                    case "watermelon": price = 56.00M * 2; break;
                    case "mango": price = 36.66M * 2; break;
                    case "pineapple": price = 42.10M * 2; break;
                    case "raspberry": price = 20.00M * 2; break;
                }
            }
            else
            {
                switch (fruit)
                {
                    case "watermelon": price = 28.70M * 5; break;
                    case "mango": price = 19.60M * 5; break;
                    case "pineapple": price = 24.80M * 5; break;
                    case "raspberry": price = 15.20M * 5; break;
                }
            }
            sumAll = price * drinks;

            if (sumAll > 1000)
                sum = sumAll - (sumAll * 0.50M);
            else if (sumAll >= 400 && sumAll <= 1000)
                sum = sumAll - (sumAll * 0.15M);
            else
                sum = sumAll;            

            Console.WriteLine("{0:f2} lv.", sum);
        }
    }
}
