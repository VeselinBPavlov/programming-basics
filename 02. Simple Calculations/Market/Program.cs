using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double prihodZelenchuci = double.Parse(Console.ReadLine());
            double prihodPlodove = double.Parse(Console.ReadLine());
            double kolichestvoZelencuci = double.Parse(Console.ReadLine());
            double kolichestvoPlodove = double.Parse(Console.ReadLine());
            double prihod = (prihodZelenchuci * kolichestvoZelencuci) + (prihodPlodove * kolichestvoPlodove);
            double prihodEUR = prihod / 1.94;
            Console.WriteLine(Math.Round(prihodEUR, 2));
        }
    }
}
