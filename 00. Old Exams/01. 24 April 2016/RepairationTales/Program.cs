using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairationTales
{
    class Program
    {
        static void Main(string[] args)
        {
            double plazaSide = double.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLength = double.Parse(Console.ReadLine());
            double benchWidth = double.Parse(Console.ReadLine());
            double benchLength = double.Parse(Console.ReadLine());

            double plazaArea = plazaSide * plazaSide;
            double benchArea = benchWidth * benchLength;
            double tileArea = tileWidth * tileLength;
            double repearArea = plazaArea - benchArea;
            double tileNeed = repearArea / tileArea;
            double timeNeed = tileNeed * 0.2;

            Console.WriteLine($"{tileNeed:f2}");
            Console.WriteLine($"{timeNeed:f2}");
        }
    }
}
