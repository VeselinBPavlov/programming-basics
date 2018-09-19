using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_PointInFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool insideHorizontalRectangle = (x > 0 && x < 3 * h) && (y > 0 && y < h);
            bool insideVerticalRectangle = (x > h && x < 2 * h) && (y > h && y < 4 * h);
            bool onMiddleSide = (x > h && x < 2 * h) && y == h;

            //Horizontal Rectangle:
            bool onBorder1 = ((x == 0 || x == 3 * h) && (y >= 0 && y <= h)) ||
                             ((y == 0 || y == h) && (x >= 0 && x <= 3 * h));

            //Vertical Rectangle:
            bool onBorder2 = ((x == h || x == 2 * h) && (y >= h && y <= 4 * h)) ||
                             ((y == 4 || y == 4 * h) && (x >= h && x <= 2 * h));

            if (insideHorizontalRectangle || insideVerticalRectangle || onMiddleSide)
            {
                Console.WriteLine("inside");
            }
            else if (onBorder1 || onBorder2)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}