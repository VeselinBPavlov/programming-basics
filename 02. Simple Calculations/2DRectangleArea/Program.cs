using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var a = Math.Max(x1, x2) - Math.Min(x1, x2);
            var b = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine(a * b);
            Console.WriteLine((a + b) * 2);
            
        }
    }
}
