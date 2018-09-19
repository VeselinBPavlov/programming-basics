using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int liliAge = int.Parse(Console.ReadLine());
            decimal priceWashingmachine = decimal.Parse(Console.ReadLine());
            decimal priceToy = decimal.Parse(Console.ReadLine());

            int toy = 0;
            decimal money = 0.00M;
            decimal sum = 0.00M;
            decimal moneyBurthday = 0.00M;
            

            for (int i = 1; i <= liliAge; i++)
            {
                if (i % 2 == 0)
                {
                    money += (moneyBurthday + (10 - 1));
                    moneyBurthday += 10;
                }
                else
                    toy++;
            }
            
            sum = (toy * priceToy) + money;

            if (sum >= priceWashingmachine)
                Console.WriteLine("Yes! {0:f2}", sum - priceWashingmachine);
            else
                Console.WriteLine("No! {0:f2}", priceWashingmachine - sum);


        }
    }
}
