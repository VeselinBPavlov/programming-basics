using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());

            double pointsTo22 = 0;
            double pointsTo40 = 0;
            double pointsTo58 = 0;
            double pointsTo76 = 0;
            double pointsTo100 = 0;

            for (int i = 1; i <= students; i++)
            {
                double points = double.Parse(Console.ReadLine());

                if (points >= 0 && points < 22.5)
                    pointsTo22++;
                if (points >= 22.5 && points < 40.5)
                    pointsTo40++;
                if (points >= 40.5 && points < 58.5)
                    pointsTo58++;
                if (points >= 58.5 && points < 76.5)
                    pointsTo76++;
                if (points >= 76.5 && points < 100)
                    pointsTo100++;
            }

            Console.WriteLine("{0:f2}% poor marks", (pointsTo22 / students) * 100);
            Console.WriteLine("{0:f2}% satisfactory marks", (pointsTo40 / students) * 100);
            Console.WriteLine("{0:f2}% good marks", (pointsTo58 / students) * 100);
            Console.WriteLine("{0:f2}% very good marks", (pointsTo76 / students) * 100);
            Console.WriteLine("{0:f2}% excellent marks", (pointsTo100 / students) * 100);
        }
    }
}
