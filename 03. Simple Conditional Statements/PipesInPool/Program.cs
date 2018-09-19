using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            double pipe1 = double.Parse(Console.ReadLine());
            double pipe2 = double.Parse(Console.ReadLine());
            double workerHours = double.Parse(Console.ReadLine());

            double debit = (pipe1 + pipe2) * workerHours;
            

            if (debit <= volume)
            {
                Console.WriteLine("The pool is " + (Math.Truncate((debit / volume) * 100)) + "% full. " +
                    "Pipe 1: " + (Math.Truncate(((pipe1 * workerHours) / debit) * 100)) + "%. Pipe 2: " + (Math.Truncate(((pipe2 * workerHours) / debit) * 100)) + "%.");
            }
            else
            {
                Console.WriteLine("For " + workerHours + " hours the pool overflows with " + (debit - volume) + " liters.");
            }

        }
    }
}
