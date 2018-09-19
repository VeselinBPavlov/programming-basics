using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = int.Parse(Console.ReadLine());

            var y = ((x >= 100 && x <= 200) || x == 0);

            if (!y)
                Console.WriteLine("Invalid");
            
        }
    }
}
