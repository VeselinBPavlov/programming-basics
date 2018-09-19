using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());

            double topStudents = 0;
            double averageStudents = 0;
            double poorStudents = 0;
            double failStudents = 0;

            double sumRate = 0;


            for (double i = 0; i < students; i++)
            {
                double rate = double.Parse(Console.ReadLine());
                sumRate += rate;

                if (rate >= 5.00)
                    topStudents++;
                if (rate < 5.00 && rate >= 4.00)
                    averageStudents++;
                if (rate < 4.00 && rate >= 3.00)
                    poorStudents++;
                if (rate < 3.00)
                    failStudents++;
            }

            double averageRate = sumRate / students;
            double perTop = (topStudents / students) * 100;
            double perAverage = (averageStudents / students) * 100;
            double perPoor = (poorStudents / students) * 100;
            double perFail = (failStudents / students) * 100;


            Console.WriteLine("Top students: {0:f2}%", perTop);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", perAverage);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", perPoor);
            Console.WriteLine("Fail: {0:f2}%", perFail);
            Console.WriteLine("Average: {0:f2}", averageRate);
        }
    }
}
