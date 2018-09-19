using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double d = r * (180 / Math.PI);
            Math.Round(d);
            Console.WriteLine(d);

        }
    }
}
