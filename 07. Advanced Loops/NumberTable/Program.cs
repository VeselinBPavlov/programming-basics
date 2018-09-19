using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var currentNum = n + 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <=n; j++)
                {
                    var number = j + i;

                    if (number > n)
                    {
                        number =  2 * n - number;
                        
                    }
                   Console.Write("{0} ", number);
                }
                Console.WriteLine();
            }
        }
    }
}
