using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sells = double.Parse(Console.ReadLine());
            double comission = -1;

            if (town == "sofia")
            {
                if (sells >= 0 && sells <= 500)
                    comission = sells * 0.05;
                if (sells > 500 && sells <= 1000)
                    comission = sells * 0.07;
                if (sells > 1000 && sells <= 10000)
                    comission = sells * 0.08;
                if (sells > 10000)
                    comission = sells * 0.12;
            }

            else if (town == "varna")
            {
                if (sells >= 0 && sells <= 500)
                    comission = sells * 0.045;
                if (sells > 500 && sells <= 1000)
                    comission = sells * 0.075;
                if (sells > 1000 && sells <= 10000)
                    comission = sells * 0.10;
                if (sells > 10000)
                    comission = sells * 0.13;

            }

            else if (town == "plovdiv")
            {
                if (sells >= 0 && sells <= 500)
                    comission = sells * 0.055;
                if (sells > 500 && sells <= 1000)
                    comission = sells * 0.08;
                if (sells > 1000 && sells <= 10000)
                    comission = sells * 0.12;
                if (sells > 10000)
                    comission = sells * 0.145;
            }
            if (comission >= 0)
                Console.WriteLine("{0:f2}", comission);
            else
                Console.WriteLine("error");
        }
    }
}
