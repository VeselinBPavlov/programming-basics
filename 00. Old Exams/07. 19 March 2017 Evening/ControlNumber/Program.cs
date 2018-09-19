using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;
            int moves = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    counter = sum + (i * 2) + (j * 3);
                    sum = counter;
                    moves++;
                    if (sum >= controlNum)
                    {
                        Console.WriteLine("{0} moves", moves);
                        Console.WriteLine("Score: {0} >= {1}", sum, controlNum);
                        return;
                    }                                       
                }
            }    
            
                Console.WriteLine("{0} moves", moves);
        }
    }
}
