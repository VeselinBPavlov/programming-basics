using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char miss = char.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = begin; i <= end; i++)
            {
                for (int j = begin; j <= end; j++)
                {
                    for (int h = begin; h <= end; h++)
                    {                       
                        if (h == miss || j == miss || i == miss)
                            continue;
                        counter++;
                        Console.Write("{0}{1}{2} ", (char)i, (char)j, (char)h);                        
                    }                    
                }
            }
            Console.WriteLine(counter);    
        }
    }
}
