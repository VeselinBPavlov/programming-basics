using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());
            decimal moneyLeft = 0.00M;
            decimal ostatak = 0.00M;
            decimal nedostig = 0.00M;
            decimal sumaBiletiVip = people * 499.99M;
            decimal sumaBiletiNormal = people * 259.99M;

            if (people <= 4)
                moneyLeft = budget - (budget * 0.75M);
            else if (people >= 5 && people <= 9)
                moneyLeft = budget - (budget * 0.60M);
            else if (people >= 10 && people <= 24)
                moneyLeft = budget  - (budget * 0.50M);
            else if (people >= 25 && people <= 49)
                moneyLeft = budget - (budget * 0.40M);
            else if (people >= 50)
                moneyLeft = budget - (budget * 0.25M);

            
            if (category == "vip" && moneyLeft >= sumaBiletiVip)
            {
                ostatak = moneyLeft - sumaBiletiVip;
                Console.WriteLine("Yes! You have {0} leva left.", ostatak);
            }
            else if (category == "normal" && moneyLeft >= sumaBiletiNormal)
            {
                ostatak = moneyLeft - sumaBiletiNormal;
                Console.WriteLine("Yes! You have {0} leva left.", ostatak);
            }
            else if (category == "vip" && moneyLeft < sumaBiletiVip)
            {
                nedostig = moneyLeft - sumaBiletiVip;
                Console.WriteLine("Not enough money! You need {0} leva.", nedostig);
            }
            else if (category == "normal" && moneyLeft < sumaBiletiNormal)
            {
                nedostig = moneyLeft - sumaBiletiNormal;
                Console.WriteLine("Not enough money! You need {0} leva.", nedostig);
            }


        }
    }
}
