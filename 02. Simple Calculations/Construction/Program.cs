using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var o = double.Parse(Console.ReadLine());
            var area = n * n;
            var bench = m * o;
            var areaConstruct = area - bench;
            var paveArea = w * l;
            var needPave = (area / paveArea);
            var needTime = needPave * 0.2;
            Console.WriteLine(needPave);
            Console.WriteLine(needTime);


        }
    }
}
