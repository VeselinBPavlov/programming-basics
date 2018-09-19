using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
         
            double redove = Math.Ceiling(l / 1.2);
            double koloni = Math.Ceiling (w - 1) / 0.7;
            double broiMesta = redove * koloni - 3;
            Console.WriteLine(broiMesta);
            
                
        }
    }
}
