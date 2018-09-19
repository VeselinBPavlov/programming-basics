using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var higth = (n * 2) + 2;
            var length = (n * 4) + 3;
            

            for (int i = 0; i < n + 1; i++)
            {
                if (i == 0)
                {
                    Console.Write("{0}{1}{0}", new string('.', n + 1), new string('_', (n * 2) + 1));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("{0}//{1}\\\\{2}", new string('.', (n + 1) - i), new string('_', ((n + i) * 2) - 3), new string('.', (n + 1) - i));
                    Console.WriteLine();
                }
            }

            Console.Write("//{0}STOP!{0}\\\\", new string('_', ((length - 7) / 2) - 1));
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.Write("\\\\{0}//", new string('_', length - 4));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("{0}\\\\{1}//{0}", new string('.', i), new string('_', (length - 2) - (i * 2) - 2));
                    Console.WriteLine();
                }
            }
        }
    }
}
