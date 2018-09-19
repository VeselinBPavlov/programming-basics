using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string myDate = Console.ReadLine();
            string format = "dd-MM-yyyy";

            var parseDate = DateTime.ParseExact(myDate, format, null);
            parseDate = parseDate.AddDays(1000 - 1);
            Console.WriteLine(parseDate.ToString(format));
        }
    }
}
