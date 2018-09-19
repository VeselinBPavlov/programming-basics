using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maximumBattles = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= begin; i++)
            {
                for (int j = 1; j <= end; j++)
                {
                    counter++;
                    Console.Write("({0} <-> {1}) ", i, j);
                    if (counter == maximumBattles)
                        return;
                }
            }
        }
    }
}
