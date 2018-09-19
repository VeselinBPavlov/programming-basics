using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomatoKg = double.Parse(Console.ReadLine());
            double traces = double.Parse(Console.ReadLine());
            double burkan = double.Parse(Console.ReadLine());

            double lutenicaVol = tomatoKg / 5;
            double burkanVol = lutenicaVol / 0.535;
            double tracesVol = burkanVol / burkan;
            double difference = Math.Abs(tracesVol - traces);

            Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(lutenicaVol));

            if (tracesVol >= traces)
            {
                Console.WriteLine("{0} boxes left.", Math.Floor(difference));
                Console.WriteLine("{0} jars left.", Math.Floor(difference * burkan));
            }
            else
            {
                Console.WriteLine("{0} more boxes needed.", Math.Floor(difference));
                Console.WriteLine("{0} more jars needed.", Math.Floor(difference * burkan));
            }
        }
    }
}
