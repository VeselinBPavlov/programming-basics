using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            double dancers = double.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string place = Console.ReadLine().ToLower();

            double reward = 0.00;           
            double charity = 0.75;
            double sumCharity = 0.00;
            double sumDancers = 0.00;
            double rewardPerDancer = 0.00;

            if (place == "bulgaria")
            {
                reward = points * dancers;

                if (season == "summer")
                    reward -= reward * 0.05;
                else if (season == "winter")
                    reward -= reward * 0.08;
            }
            else if (place == "abroad")
            {
                reward = points * dancers;
                reward += reward * 0.5;

                if (season == "summer")
                    reward -= reward * 0.1;
                else if (season == "winter")
                    reward -= reward * 0.15;
            }

            sumCharity = reward * charity;
            sumDancers = reward - sumCharity;
            rewardPerDancer = sumDancers / dancers;

            Console.WriteLine("Charity - {0:f2}", sumCharity);
            Console.WriteLine("Money per dancer - {0:f2}", rewardPerDancer);
        }
    }
}
