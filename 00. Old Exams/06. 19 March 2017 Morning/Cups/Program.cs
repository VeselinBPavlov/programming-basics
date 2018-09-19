using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal targetGlasses = decimal.Parse(Console.ReadLine());
            decimal workers = decimal.Parse(Console.ReadLine());
            decimal workingDays = decimal.Parse(Console.ReadLine());

            decimal sumWorkingTime = workers * workingDays * 8;
            decimal glasses = Math.Floor(sumWorkingTime / 5);

            decimal result = Math.Abs(targetGlasses - glasses);
            decimal sumResult = result * 4.20M;

            if (glasses > targetGlasses)
                Console.WriteLine("{0:f2} extra money", sumResult);
            else
                Console.WriteLine("Losses: {0:f2}", sumResult);
        }
    }
}
