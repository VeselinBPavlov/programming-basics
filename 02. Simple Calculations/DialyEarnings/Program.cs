using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialyEarnings
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDaysMonthly = int.Parse(Console.ReadLine());
            double earnMoneyDay = double.Parse(Console.ReadLine());
            double rateUSD = double.Parse(Console.ReadLine());
            double monthPayment = workDaysMonthly * earnMoneyDay;
            double yearPayment = monthPayment * 12;
            double yearPaymentBonus = yearPayment + (2.5 * monthPayment);
            double netPayment = yearPaymentBonus - yearPaymentBonus * 0.25;
            double netPaymentBGN = netPayment * rateUSD;
            double netDayPayment = netPaymentBGN / 365;
            Console.WriteLine(Math.Round(netDayPayment, 2));



        }
    }
}
