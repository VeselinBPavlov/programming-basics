using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int control = int.Parse(Console.ReadLine());

            bool found = false;

            for (int a = 1; a <= 30; a++)
                for (int b = 1; b <= 30; b++)
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a + b + c == control && a < b && b < c)
                        {
                            found = true;
                            Console.WriteLine($"{a} + {b} + {c} = {control}");
                        }
                        if (a * b * c == control && a > b && b > c)
                        {
                            found = true;
                            Console.WriteLine($"{a} * {b} * {c} = {control}");
                        }
                    }

            if (!found) Console.WriteLine("No!");

        }
    }
}