using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string DayOfWeek = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());                  
            double price = 0.0;

            if (DayOfWeek == "saturday" || DayOfWeek == "sunday")
            {
                switch (fruit)
                {
                    case "banana": price = quantity * 2.70; break;
                    case "apple": price = quantity * 1.25; break;
                    case "orange": price = quantity * 0.90; break;                  
                    case "grapefruit": price = quantity * 1.60; break;
                    case "kiwi": price = quantity * 3.00; break;
                    case "pineapple": price = quantity * 5.60; break;
                    case "grapes": price = quantity * 4.20; break;

                    default:
                        break;
                }
            }
        
            else if (DayOfWeek == "monday" ||
                     DayOfWeek == "tuesday" ||
                     DayOfWeek == "wednesday" ||
                     DayOfWeek == "thursday" ||
                     DayOfWeek == "friday")
            {
                switch (fruit)
                {
                    case "banana": price = quantity * 2.50; break;
                    case "apple": price = quantity * 1.20; break;
                    case "orange": price = quantity * 0.85; break;                 
                    case "grapefruit": price = quantity * 1.45; break;
                    case "kiwi": price = quantity * 2.70; break;
                    case "pineapple": price = quantity * 5.50; break;
                    case "grapes": price = quantity * 3.85; break;

                    default:
                        break;
                }
            }

          
            if (price != 0.0)
            {
                Console.WriteLine("{0:F2}", price);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
