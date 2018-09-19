using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractTerm = Console.ReadLine().ToLower();
            string typeContract = Console.ReadLine().ToLower();
            string mobileInternet = Console.ReadLine().ToLower();
            int months = int.Parse(Console.ReadLine());

            decimal monthTax = 0.00M;
            decimal mobileInternetTax = 0.00M;
            decimal discount = 0.0375M;
            decimal sum = 0.00M;
            decimal allSum = 0.00M;
            bool internet = (mobileInternet == "yes");


            if (contractTerm == "one")
            {
                switch(typeContract)
                {
                    case "small": monthTax = 9.98M; break;
                    case "middle": monthTax = 18.99M; break;
                    case "large": monthTax = 25.98M; break;
                    case "extralarge": monthTax = 35.99M; break;
                }
            }
            else
            {
                switch (typeContract)
                {
                    case "small": monthTax = 8.58M; break;
                    case "middle": monthTax = 17.09M; break;
                    case "large": monthTax = 23.59M; break;
                    case "extralarge": monthTax = 31.79M; break;
                }
            }

            if (internet && monthTax <= 10)
                mobileInternetTax = 5.50M;
            else if (internet && monthTax > 10 && monthTax <= 30)
                mobileInternetTax = 4.35M;
            else if (internet && monthTax > 30)
                mobileInternetTax = 3.85M;

            if (contractTerm == "two")
                sum = (monthTax + mobileInternetTax) - ((monthTax + mobileInternetTax) * discount);
            else
                sum = monthTax + mobileInternetTax;

            allSum = sum * months;

            Console.WriteLine("{0:f2} lv.", allSum);

        }
    }
}
