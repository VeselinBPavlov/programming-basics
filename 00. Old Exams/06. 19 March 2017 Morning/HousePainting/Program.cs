using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double side = x * y;
            double window = 1.5 * 1.5;
            double sidesArea = (side * 2) - (window * 2);
            double backSide = x * x;
            double door = 1.2 * 2;
            double frontBackSides = (backSide * 2) - door;
            double areaDown = sidesArea + frontBackSides;
            double greenPaint = areaDown / 3.4;

            double sidesRoof = 2 * (x * y);
            double frontBackRoof = 2 * ((x * h) / 2);
            double areaRoof = sidesRoof + frontBackRoof;
            double redPaint = areaRoof / 4.3;

            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}
