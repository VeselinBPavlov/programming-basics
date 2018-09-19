using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            string num = null;
            int realNum;

            

            for (int i = firstNumber; i >= 1; i--)
            {
                for (int j = secondNumber; j >= 1; j--)
                {
                    for (int k = thirdNumber; k >= 1; k--)
                    {
                        num = i.ToString() + j.ToString() + k.ToString();
                        realNum = int.Parse(num);

                        if (realNum % 3 == 0)
                            specialNumber += 5;
                        else if (realNum % 3 != 0 && realNum % 10 == 5)
                            specialNumber -= 2;
                        else if (realNum % 3 != 0 && realNum % 10 != 5 && realNum % 2 == 0)
                            specialNumber *= 2;

                        if (specialNumber >= controlNumber)                       
                            break;                                     
                    }
                    if (specialNumber >= controlNumber)
                        break;
                }
                if (specialNumber >= controlNumber)
                    break;
            }
            if (specialNumber >= controlNumber)
                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNumber);
            else
                Console.WriteLine("No! {0} is the last reached special number.", specialNumber);
        }
    }
}
