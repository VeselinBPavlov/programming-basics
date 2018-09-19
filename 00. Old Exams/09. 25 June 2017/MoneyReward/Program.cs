using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyReward
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            decimal rewarProject = decimal.Parse(Console.ReadLine());

            int count = 0;
            decimal reward = 0.00M;

            for (int i = 1; i <= parts; i++)
            {
                int points = int.Parse(Console.ReadLine());

                if (i % 2 == 1)
                    count += points;
                if (i % 2 == 0)
                    count += points * 2;
            }

            reward = rewarProject * count;

            Console.WriteLine("The project prize was {0:f2} lv.", reward);
        }
    }
}
