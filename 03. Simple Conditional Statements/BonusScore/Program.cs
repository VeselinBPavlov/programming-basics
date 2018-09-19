using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());
            double bonus = 0;
            double bonus1 = 0;
            double bonus2 = 0;

            if (score <= 100)
            {
                bonus = bonus + 5;
            }
            else if (score > 1000)
            {
                bonus = score * 0.1;
            }
            else if (score > 100)
            {
                bonus = score * 0.2;
            }

            if (score % 2 == 0) 
            {
                bonus1 = bonus1 + 1;
            }
            else
            {
                bonus1 = bonus1 + 0;
            }

            if (score % 5 == 0 && score % 2 == 1)
            {
                bonus2 = bonus2 + 2;
            }
            else
            {
                bonus2 = bonus2 + 0;
            }
            Console.WriteLine(bonus + bonus1 + bonus2);
            Console.WriteLine(score + bonus + bonus1 + bonus2);
                        
        }
    }
}
