using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int racer1 = int.Parse(Console.ReadLine());
            int racer2 = int.Parse(Console.ReadLine());
            int racer3 = int.Parse(Console.ReadLine());

            int seconds = racer1 + racer2 + racer3;
            int minutes = 0;

            if (seconds <= 59)
            {
                minutes = 0;
            }
            else if (seconds > 59 && seconds <= 119)
            {
                minutes++;
                seconds = seconds - 60;
            }
            else if (seconds > 119 && seconds<= 179)
            {
                minutes += 2;
                seconds = seconds - 120;
            }

            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":" + "0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
            
        }


    }
    
}
