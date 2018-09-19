using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            string sign = Console.ReadLine();

            decimal result = 0.00M;
            string plus = "+";
            string minus = "-";
            string obelus = "/";
            string times = "*";
            string moduldevide = "%";

            decimal sum = x + y;
            decimal multiply = x * y;
            decimal difference = x - y;
            

            bool action = (sign == plus || sign == times || sign == minus);


            if ((sign == obelus || sign == moduldevide) && y == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", y);
            }

            else if (action == true)
            {
                if (sign == plus)
                {
                    result = sum;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{0} + {1} = {2} - even", x, y, result);
                    }
                    else
                    {
                        Console.WriteLine("{0} + {1} = {2} - odd", x, y, result);
                    }
                }
                else if (sign == times)
                {
                    result = multiply;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{0} * {1} = {2} - even", x, y, result);
                    }
                    else
                    {
                        Console.WriteLine("{0} * {1} = {2} - odd", x, y, result);
                    }
                }
                else if (sign == minus)
                {
                    result = difference;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{0} - {1} = {2} - even", x, y, result);
                    }
                    else
                    {
                        Console.WriteLine("{0} - {1} = {2} - odd", x, y, result);
                    }
                }

            }
            else if (sign == obelus)
            {
                result = x / y;
                Console.WriteLine("{0} / {1} = {2:f2}", x, y, result);
            }
            else if (sign == moduldevide)
            {
                result = x % y;
                Console.WriteLine("{0} % {1} = {2}", x, y, result);
            }  
        }
    }
}
