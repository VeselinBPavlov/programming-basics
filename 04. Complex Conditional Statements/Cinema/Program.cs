using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProject = Console.ReadLine().ToLower();
            double row = double.Parse(Console.ReadLine());
            double coloumn = double.Parse(Console.ReadLine());

            double seats = coloumn * row;
            double income = 0.00;

            switch (typeProject)
            {
                case "premiere": income = seats * 12; break;
                case "normal": income = seats * 7.50; break;
                case "discount": income = seats * 5.00; break;
                default: break;
            }
            Console.WriteLine(Math.Round(income, 2));
        }
    }
}
