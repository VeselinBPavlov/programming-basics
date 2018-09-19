using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinutes;
            int arriveTime = arriveHour * 60 + arriveMinutes;
            int diff = examTime - arriveTime;

            if (diff <= -1)
            {
                Console.WriteLine("Late");
                if (diff <= -1 && diff >= -59)
                {
                    Console.WriteLine("{0} minutes after the start", Math.Abs(diff));
                }
                else if (diff < -59 && diff >= -69)
                {
                    Console.WriteLine("{0}:0{1} hours after the start", Math.Abs(diff / 60), Math.Abs(diff % 60));
                }
                else if (diff < -69)
                {
                    Console.WriteLine("{0}:{1} hours after the start", Math.Abs(diff / 60), Math.Abs(diff % 60));
                }
            }
            else if (diff >= 0 && diff <= 30)
            {
                Console.WriteLine("On Time");
                if (diff <= 30)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(diff));
                }
            }
            else if (diff > 30)
            {
                Console.WriteLine("Early");
                if (diff > 30 && diff <= 59)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(diff));
                }
                else if (diff > 59 && diff <= 69)
                {
                    Console.WriteLine("{0}:0{1} hours before the start", Math.Abs(diff / 60), Math.Abs(diff % 60));
                }
                else if (diff > 69)
                {
               
                    if (diff > 69 && diff % 60 == 0)
                    {
                        Console.WriteLine("{0}:0{0} hours before the start", Math.Abs(diff / 60), Math.Abs(diff % 60));
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours before the start", Math.Abs(diff / 60), Math.Abs(diff % 60));
                    }
                }
            }
        }
    }
}

