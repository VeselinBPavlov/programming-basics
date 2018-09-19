using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLeva = int.Parse(Console.ReadLine());
            int twoLeva = int.Parse(Console.ReadLine());
            int fiveLeva = int.Parse(Console.ReadLine());
            int sumLeva = int.Parse(Console.ReadLine());


            for (int i = 0; i <= oneLeva; i++)
            {
                for (int j = 0; j <= twoLeva; j++)
                {
                    for (int k = 0; k <= fiveLeva; k++)
                    {
                        bool calc = (i * 1 + j * 2 + k * 5 == sumLeva);
                        if (calc == true)
                            Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.", i, j, k, sumLeva);
                    }
                }
            }             
        }
    }
}
