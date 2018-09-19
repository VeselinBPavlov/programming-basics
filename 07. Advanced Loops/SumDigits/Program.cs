using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            var remainder = n;

            while(remainder > 0)
            {
                var lastDigit = remainder % 10;
                remainder = remainder / 10;
                sum += lastDigit;
            }
            Console.WriteLine(sum);

            
            //for (int i = 0; i < m.Length; i++)
            //{
            //    sum += int.Parse(m[i].ToString());
            //}     
                       
        }
    }
}
