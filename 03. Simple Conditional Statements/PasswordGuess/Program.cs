using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            string passout = "s3cr3t!P@ssw0rd";

            if (pass == passout)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
