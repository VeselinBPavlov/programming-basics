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
            decimal lengthNet = decimal.Parse(Console.ReadLine());
            decimal wigthNet = decimal.Parse(Console.ReadLine());
            decimal higthNet = decimal.Parse(Console.ReadLine());
            decimal priceNet = decimal.Parse(Console.ReadLine());
            decimal weigthNet = decimal.Parse(Console.ReadLine());

            decimal allLength = (2 * lengthNet) + (2 * wigthNet);
            decimal allPrice = allLength * priceNet;
            decimal areaNet = allLength * higthNet;
            decimal allWeigth = areaNet * weigthNet;

            Console.WriteLine(allLength);
            Console.WriteLine($"{allPrice:f2}");
            Console.WriteLine($"{allWeigth:f3}");

        }
    }
}
