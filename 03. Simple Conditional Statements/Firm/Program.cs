using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int projectHours = int.Parse(Console.ReadLine());
            int projectDays = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double workDays = (projectDays * 0.9);
            double workHours = (workDays * 8 * workers);
            double overtime = (workDays * 2 * workers);

            double projectTime = Math.Floor (workHours + overtime);

            if (projectHours <= projectTime)
            {
                Console.WriteLine($"Yes!{projectTime - projectHours} hours left.");
               
            }
            else
            {
                Console.WriteLine($"Not enough time!{projectHours - projectTime} hours needed.");
            }

        }
    }
}
