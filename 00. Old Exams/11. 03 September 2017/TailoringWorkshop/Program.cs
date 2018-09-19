using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tables = double.Parse(Console.ReadLine());
            double lengthTable = double.Parse(Console.ReadLine());
            double weigthTable = double.Parse(Console.ReadLine());

            double areaCover = tables * (lengthTable + 2 * 0.3) * (weigthTable + 2 * 0.3);
            double areaKare = tables * (lengthTable / 2) * (lengthTable / 2);
            double sumUsd = (areaCover * 7) + (areaKare * 9);
            double sumBgn = sumUsd * 1.85;
            
            Console.WriteLine("{0:f2} USD", sumUsd);
            Console.WriteLine("{0:f2} BGN", sumBgn);
        }
    }
}
