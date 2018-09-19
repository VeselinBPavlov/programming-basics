using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingHours2
{
    class Program
    {
        static void Main(string[] args)
        {
            int needHours = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            int workingHours = workers * workingDays * 8;

            if (workingHours > needHours)
                Console.WriteLine("{0} hours left", workingHours - needHours);
            else
            {
                Console.WriteLine("{0} overtime", needHours - workingHours);
                Console.WriteLine("Penalties: {0}", (needHours - workingHours) * workingDays);
            }
        }
    }
}
