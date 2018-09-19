using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal vineyardArea = decimal.Parse(Console.ReadLine());
            decimal kgm2 = decimal.Parse(Console.ReadLine());
            decimal waste = decimal.Parse(Console.ReadLine());

            decimal yeild = (vineyardArea * kgm2) - waste;
            decimal grape = yeild * 0.55M;
            decimal grapeRakia = yeild * 0.45M;
            decimal rakia = grapeRakia / 7.5M;
            decimal rakiaSum = rakia * 9.80M;
            decimal grapeSum = grape * 1.50M;

            Console.WriteLine("{0:f2}", rakiaSum);
            Console.WriteLine("{0:f2}", grapeSum);
        }
    }
}
