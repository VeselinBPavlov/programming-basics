using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lectures = int.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal wage = budget / lectures;

            decimal jelevSalary = 0.00M;
            decimal royalSalary = 0.00M;
            decimal roliSalary = 0.00M;
            decimal trofonSalary = 0.00M;
            decimal sinoSalary = 0.00M;
            decimal otherTrainersSalary = 0.00M;

            for (int i = 0; i < lectures; i++)
            {
                string trainer = Console.ReadLine().ToLower();

                if (trainer == "jelev")
                    jelevSalary += wage;
                else if (trainer == "royal")
                    royalSalary += wage;
                else if (trainer == "roli")
                    roliSalary += wage;
                else if (trainer == "trofon")
                    trofonSalary += wage;
                else if (trainer == "sino")
                    sinoSalary += wage;
                else
                    otherTrainersSalary += wage;
            }

            Console.WriteLine("Jelev salary: {0:f2} lv", jelevSalary);
            Console.WriteLine("RoYaL salary: {0:f2} lv", royalSalary);
            Console.WriteLine("Roli salary: {0:f2} lv", roliSalary);
            Console.WriteLine("Trofon salary: {0:f2} lv", trofonSalary);
            Console.WriteLine("Sino salary: {0:f2} lv", sinoSalary);
            Console.WriteLine("Others salary: {0:f2} lv", otherTrainersSalary);
        }
    }
}
