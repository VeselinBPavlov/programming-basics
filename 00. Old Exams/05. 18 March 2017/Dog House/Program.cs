using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sideA = decimal.Parse(Console.ReadLine());
            decimal heigthHouse = decimal.Parse(Console.ReadLine());

            decimal bouthSides = sideA * (sideA / 2) * 2;
            decimal backSideBottom = (sideA / 2) * (sideA / 2);
            decimal backSideTop = ((sideA / 2) * (heigthHouse - (sideA / 2))) / 2;
            decimal backSide = backSideTop + backSideBottom;
            decimal entr = (sideA / 5) * (sideA / 5);
            decimal frontSide = backSide - entr;
            decimal areaGreen = bouthSides + backSide + frontSide;
            decimal greenPaint = areaGreen / 3;

            decimal roof = sideA * (sideA / 2) * 2;
            decimal redPaint = roof / 5;

            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}
