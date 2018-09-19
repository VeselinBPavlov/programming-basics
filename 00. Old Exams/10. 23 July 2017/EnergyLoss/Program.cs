using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Program
    {
        static void Main(string[] args)
        {
            int traningDays = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());

            double allEnergy = 0;
            double unusedEnergy = 0;
            double dancerEnergy = 100;
            double energyDancer = 0;
            double usedEnergy = 0;
            double unusedEnergyPerDander = 0;

            for (int i = 1; i <= traningDays; i++)
            {
                int traningHours = int.Parse(Console.ReadLine());

                if (i % 2 == 0 && traningHours % 2 == 0)
                    energyDancer += 68;
                else if (i % 2 == 1 && traningHours % 2 == 0)
                    energyDancer += 49;
                else if (i % 2 == 0 && traningHours % 2 == 1)
                    energyDancer += 65;
                else if (i % 2 == 1 && traningHours % 2 == 1)
                    energyDancer += 30;                
            }

            usedEnergy = energyDancer * dancers;
            allEnergy = dancerEnergy * traningDays * dancers;
            unusedEnergy = allEnergy - usedEnergy;
            unusedEnergyPerDander = unusedEnergy / dancers / traningDays;

            if (unusedEnergyPerDander >= 50)
                Console.WriteLine("They feel good! Energy left: {0:f2}", unusedEnergyPerDander);
            else
                Console.WriteLine("They are wasted! Energy left: {0:f2}", unusedEnergyPerDander);
        }
    }
}
