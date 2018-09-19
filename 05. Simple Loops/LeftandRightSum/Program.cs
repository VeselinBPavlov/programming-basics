using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var LeftSUM = 0;
            var RightSUM = 0;
            var Difference = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                LeftSUM += num;
            }

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                RightSUM += num;
            }

            if (RightSUM == LeftSUM)
                Console.WriteLine("Yes, sum = {0}", RightSUM);
            else
            {
                Difference = Math.Abs(RightSUM - LeftSUM);
                Console.WriteLine("No, diff = {0}", Difference);
            }
        }
    }
}
