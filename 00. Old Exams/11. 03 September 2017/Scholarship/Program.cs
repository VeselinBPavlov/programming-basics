using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageAsessment = double.Parse(Console.ReadLine());
            double minWorkWage = double.Parse(Console.ReadLine());

            double socScholarship = 0.35 * minWorkWage;
            double sucScholarship = averageAsessment * 25;

           
            if (income > minWorkWage && averageAsessment < 5.50)
                Console.WriteLine("You cannot get a scholarship!");
            else if (income < minWorkWage && averageAsessment < 4.50)
                Console.WriteLine("You cannot get a scholarship!");
            else if (income >= minWorkWage && averageAsessment >= 5.50)
            {              
                Console.WriteLine("You get a scholarship for excellent results {0:00} BGN", Math.Floor(sucScholarship));
            }
            else if (income < minWorkWage && averageAsessment >= 5.50)
            {             
                if (sucScholarship > socScholarship)
                    Console.WriteLine("You get a scholarship for excellent results {0:00} BGN", sucScholarship);
                else
                    Console.WriteLine("You get a Social scholarship {0:00} BGN", socScholarship);
            }
            else if (income < minWorkWage && averageAsessment >= 4.50 && averageAsessment < 5.50)
            {            
                Console.WriteLine("You get a Social scholarship {0:00} BGN", socScholarship);
            }        
        }
    }
}
