using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double widgth = double.Parse(Console.ReadLine());
            double sideCheckroom = double.Parse(Console.ReadLine());

            double lengthCm = length * 100;
            double widgthCm = widgth * 100;
            double sideCheckroomCm = sideCheckroom * 100;

            double areaRoom = lengthCm * widgthCm;
            double areaCheckroom = sideCheckroomCm * sideCheckroomCm;
            double areaBench = areaRoom / 10;

            double areaFree = areaRoom - areaCheckroom - areaBench;

            double dancers = areaFree / (7000 + 40);

            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
