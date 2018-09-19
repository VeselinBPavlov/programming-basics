using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = double.Parse(Console.ReadLine());
            var f = (1.8 * c) + 32;
            Console.WriteLine(f);
        }
    }
}
