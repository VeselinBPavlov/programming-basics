using System;

namespace problem06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int ctr = 0;
            string password = null;
            for (int i = 1; i <= 9; i++)
                for (int j = 1; j <= 9; j++)
                    for (int k = 1; k <= 9; k++)
                        for (int l = 1; l < 9; l++)
                            if (i < j && k > l)
                            {
                                int calculation = i * j + k * l;
                                if (calculation == m)
                                {
                                    Console.Write($"{i}{j}{k}{l} ");
                                    ctr++;
                                    if (ctr == 4)
                                        password = $"{i}{j}{k}{l}";
                                }
                            }
            if (ctr > 0)
                Console.WriteLine();
            if (password != null)
                Console.WriteLine($"Password: {password}");
            else
                Console.WriteLine("No!");
        }
    }
}

