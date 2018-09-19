using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main()
        {
            double bitcoin = double.Parse(Console.ReadLine());
            double ioanas = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());


            bitcoin = bitcoin * 1168;
            ioanas = (ioanas * 0.15) * 1.76;
            double resultinevro = (bitcoin + ioanas) / 1.95;
            comision = resultinevro * (comision / 100);
            double result = resultinevro - comision;
            Console.WriteLine("{0}", result);
        }
    }



}
  