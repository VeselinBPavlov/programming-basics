using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double sum = 0;
            double perP1 = 0;
            double perP2 = 0;
            double perP3 = 0;


            for (int i = 0; i < num; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                    p1++;
                if (currentNumber % 3 == 0)
                    p2++;
                if (currentNumber % 4 == 0)
                    p3++;
            }
            
            perP1 = (p1 / num) * 100;
            perP2 = (p2 / num) * 100;
            perP3 = (p3 / num) * 100;

            Console.WriteLine("{0:f2}%", perP1);
            Console.WriteLine("{0:f2}%", perP2);
            Console.WriteLine("{0:f2}%", perP3);
        }
    }
}
