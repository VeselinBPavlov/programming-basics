﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
        

            if (grade>=5.50) 
            {
                Console.WriteLine("Excellent!");
            }
           
        }
    }
}
