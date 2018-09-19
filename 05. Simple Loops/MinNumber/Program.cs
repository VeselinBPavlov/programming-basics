using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int min = int.Parse(Console.ReadLine());

            for (int i = 0; i < num - 1; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < min)
                    min = currentNumber;
            }
            Console.WriteLine(min);
        }
    }
}
