using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());

            double firstDistance = speed * (firstTime / 60);
            double secondSpeed = speed + (speed * 0.10);
            double thirdSpeed = secondSpeed - (secondSpeed * 0.05);
            double secondDistance = secondSpeed * (secondTime / 60);
            double thirdDistance = thirdSpeed * (thirdTime / 60);

            double allDistance = firstDistance + secondDistance + thirdDistance;

            Console.WriteLine("{0:f2}", allDistance);
        }
    }
}
