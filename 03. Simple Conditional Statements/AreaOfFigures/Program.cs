using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();

            if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var area = a * a;
                Console.WriteLine(area);
            }
            else if (figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var area = a * b;
                Console.WriteLine(area);
            }
            else if (figure == "circle")
            {
                var a = double.Parse(Console.ReadLine());
                var area = Math.PI * a * a;
                Console.WriteLine(area);
            }
            else if (figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var area = (a * b) / 2;
                Console.WriteLine(area);
            }
        }
    }
}
