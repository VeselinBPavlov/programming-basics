using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleStars
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 10;
            string myString = new string('*', 10);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myString);
            }                                 
        }
    }
}
