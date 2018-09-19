using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            string time = Console.ReadLine().ToLower();
            double price = 0;

            if (time == "day" && distance < 20)
            {
                price = 0.70 + (distance * 0.79);
            }
            else if (time == "night" && distance < 20)
            {
                price = 0.70 + (distance * 0.90);
            }
            else if (distance >= 100)
            {
                price = 0.06 * distance;
            }
            else
            {
                price = 0.09 * distance;
            }
            
            Console.WriteLine(price);



        }
    }
}
