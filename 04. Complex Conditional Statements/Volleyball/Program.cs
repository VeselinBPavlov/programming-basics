using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine().ToLower();
            double holiday = double.Parse(Console.ReadLine());
            double weeksInHometown = double.Parse(Console.ReadLine());

            double weeksInSofia = 48 - weeksInHometown;
            double playInSofia = weeksInSofia * (3.00 / 4.00);
            double playInHomeTown = weeksInHometown;
            double playInHollidays = holiday * (2.00 / 3.00);
            double play = playInSofia + playInHomeTown + playInHollidays;
                
            if (typeYear == "normal")
                Console.WriteLine(Math.Floor(play));
            else if (typeYear == "leap")
                Console.WriteLine(Math.Floor (play + (play * 0.15)));               
            

        }
    }
}
