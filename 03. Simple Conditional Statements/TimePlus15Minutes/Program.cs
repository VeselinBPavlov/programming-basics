using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chas
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int minutesPlus15 = minutes + 15;

            if (minutesPlus15 > 59)
            {
                hour++;
                minutesPlus15 -= 60;
            }
            if (hour == 24)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{minutesPlus15:00}");
        }
    }
}
