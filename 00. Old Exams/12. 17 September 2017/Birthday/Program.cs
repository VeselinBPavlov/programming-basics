using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double wigth = double.Parse(Console.ReadLine());
            double higth = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volumeCm = lenght * wigth * higth;
            double volumeLiters = volumeCm * 0.001;
            double per = percent * 0.01;
            double literNeed = volumeLiters * (1 - per);

            Console.WriteLine("{0:f3}", literNeed);
        }
    }
}
