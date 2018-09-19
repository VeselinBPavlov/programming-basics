using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double stepsSum = double.Parse(Console.ReadLine());
            double dancersSum = double.Parse(Console.ReadLine());
            double dayTeaching = double.Parse(Console.ReadLine());

            double stepsByDay = Math.Ceiling((1 * 100 / dayTeaching));


            double stepsPer = stepsByDay / dancersSum;

            if (stepsByDay <= 13)
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", stepsPer);
            else
                Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.", stepsPer);
        }
    }
}
