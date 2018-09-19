using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal magnolia = decimal.Parse(Console.ReadLine());
            decimal hyacinth = decimal.Parse(Console.ReadLine());
            decimal rose = decimal.Parse(Console.ReadLine());
            decimal cactus = decimal.Parse(Console.ReadLine());
            decimal priceGift = decimal.Parse(Console.ReadLine());

            decimal income = (magnolia * 3.25M) + (hyacinth * 4.00M) + (rose * 3.50M) + (cactus * 8.00M);
            decimal netProfit = income - (income * 0.05M);

            if (netProfit >= priceGift)
                Console.WriteLine("She is left with {0} leva.", Math.Floor(netProfit - priceGift));
            else
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(priceGift - netProfit));
        }
    }
}
