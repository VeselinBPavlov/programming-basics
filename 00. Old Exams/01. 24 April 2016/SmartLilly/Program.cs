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
            decimal age = decimal.Parse(Console.ReadLine());
            decimal washingmachinePrice = decimal.Parse(Console.ReadLine());
            decimal toyPrice = decimal.Parse(Console.ReadLine());

            decimal sumBirthday = 0;
            decimal toys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)
                    toys++;
                else
                {
                    sumBirthday += (i / 2) * 10;
                    sumBirthday--;
                }
            }

            decimal sumToys = toys * toyPrice;
            decimal sum = sumToys + sumBirthday;

            if (sum >= washingmachinePrice)
                Console.WriteLine("Yes! {0:f2}", sum - washingmachinePrice);
            else
                Console.WriteLine("No! {0:f2}", washingmachinePrice - sum);
        }
    }
}
