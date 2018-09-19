using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupName
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            char fourthChar = char.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int counter = -1;

            for (int i = 'A'; i <= firstChar; i++)
            {
                for (int j = 'a'; j <= secondChar; j++)
                {
                    for (int k = 'a'; k <= thirdChar; k++)
                    {
                        for (int l  = 'a'; l <= fourthChar; l ++)
                        {
                            for (int m = 0; m <= number; m++)
                            {
                                counter++;
                            }
                        }
                    }

                }
            }

            Console.WriteLine(counter);
        }
    }
}
