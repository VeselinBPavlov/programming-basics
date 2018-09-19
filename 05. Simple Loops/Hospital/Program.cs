using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            int pacientExamination = 0;
            int pacientUnexamination = 0;

            for (int i = 1; i <= period; i++)
            {
                int pacient = int.Parse(Console.ReadLine());

                if (pacient > doctors && i % 3 == 0)
                {
                    doctors++;
                }

                if (pacient <= doctors)
                {
                    pacientExamination += pacient;
                }                
                else if (pacient > doctors)
                {
                    pacientExamination += doctors;
                    pacientUnexamination += (pacient - doctors);
                }
            }
            Console.WriteLine("Treated patients: {0}.", pacientExamination);
            Console.WriteLine("Untreated patients: {0}.", pacientUnexamination);
        }
    }
}
