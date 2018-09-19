using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            string sign = Console.ReadLine();

            double result = 0;
            string evenOdd = "";

            if (b == 0 && (sign == "/" || sign == "%"))
            {
                Console.WriteLine($"Cannot divide {a} by zero");
                return;
            }

            switch (sign)
            {
                case "+": result = a + b; break;
                case "-": result = a - b; break;
                case "*": result = a * b; break;
                case "%": result = a % b; break;
                case "/": result = a / b; break;
            }

            if (result % 2 == 0)
                evenOdd = "even";
            else
                evenOdd = "odd";
            
            if (sign == "+")
                Console.WriteLine($"{a} + {b} = {result} - {evenOdd}");
            if (sign == "-")
                Console.WriteLine($"{a} - {b} = {result} - {evenOdd}");
            if (sign == "*")
                Console.WriteLine($"{a} * {b} = {result} - {evenOdd}");
            if (sign == "/")
                Console.WriteLine($"{a} / {b} = {result:f2}");
            if (sign == "%")
                Console.WriteLine($"{a} % {b} = {result}");
        }
    }
}
