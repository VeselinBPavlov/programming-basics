using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int combinations = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = begin; i <= end; i++)
            {
                for (int j = begin; j <= end; j++)
                {
                    counter++;
                    Console.Write("<{0}-{1}>", i, j);
                    if (counter == combinations)
                        return;
                }
            }
        }
    }
}
