using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertricConvertor2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sm = 100;
            var size = double.Parse(Console.ReadLine());
            var sourceMetric = Console.ReadLine().ToLower();
            var destMetric = Console.ReadLine().ToLower();

            // to metric
            if (sourceMetric == "mm") size = size / 1000;
            else if (sourceMetric == "cm") size = size / 100;
            else if (sourceMetric == "mi") size = size / 0.000621371192;
            else if (sourceMetric == "in") size = size / 39.3700787;
            else if (sourceMetric == "km") size = size / 0.001;
            else if (sourceMetric == "ft") size = size / 3.2808399;
            else if (sourceMetric == "yd") size = size / 1.0936133;

            // from metric to...
            if (destMetric == "mm") size = size * 1000;
            else if (destMetric == "cm") size = size * 100;
            else if (destMetric == "mi") size = size * 0.000621371192;
            else if (destMetric == "in") size = size * 39.3700787;
            else if (destMetric == "km") size = size * 0.001;
            else if (destMetric == "ft") size = size * 3.2808399;
            else if (destMetric == "yd") size = size * 1.0936133;

            Console.WriteLine(size + " " + destMetric);


        }
    }
}
