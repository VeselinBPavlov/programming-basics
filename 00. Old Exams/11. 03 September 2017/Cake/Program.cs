using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());

            
            string pieces = Console.ReadLine().ToLower();
            int totalCakePieces = cakeWidth * cakeLength;

            do
            {
                int currentPiece = int.Parse(pieces);
                pieces = Console.ReadLine();
                totalCakePieces -= currentPiece;

                if (totalCakePieces < 0)
                {
                    Console.WriteLine("No more cake left!You need {0} pieces more.", Math.Abs(totalCakePieces));
                    break;
                }
            } while (pieces != "stop");

            Console.WriteLine("{0} pieces are left.", totalCakePieces);     
            
        }
    }
}
