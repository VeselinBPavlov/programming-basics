using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double sum = 0;

            double pr1 = 0.00;
            double pr2 = 0.00;
            double pr3 = 0.00;
            double pr4 = 0.00;
            double pr5 = 0.00;

            for (int i = 0; i < num; i++)
            {
                double currentNumber = Double.Parse(Console.ReadLine());

                sum ++;

                if (currentNumber < 200)
                    p1 ++;
                else if (currentNumber >= 200 && currentNumber <= 399)
                    p2 ++;
                else if (currentNumber >= 400 && currentNumber <= 599)
                    p3 ++;
                else if (currentNumber >= 600 && currentNumber <= 799)
                    p4 ++;
                else if (currentNumber >= 800)
                    p5 ++;                
            }
            pr1 = (p1 / sum) * 100;
            pr2 = (p2 / sum) * 100;
            pr3 = (p3 / sum) * 100;
            pr4 = (p4 / sum) * 100;
            pr5 = (p5 / sum) * 100;

            Console.WriteLine("{0:f2}", pr1);
            Console.WriteLine("{0:f2}", pr2);
            Console.WriteLine("{0:f2}", pr3);
            Console.WriteLine("{0:f2}", pr4);
            Console.WriteLine("{0:f2}", pr5);           
        }
    }
}
