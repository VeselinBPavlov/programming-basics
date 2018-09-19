using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal weigthStuff = decimal.Parse(Console.ReadLine());
            string typeService = Console.ReadLine().ToLower();
            decimal distance = decimal.Parse(Console.ReadLine());

            decimal pricePerKm = 0.00M;
            decimal moreExp = 0.00M;
            decimal priceDelivery = 0.00M;
            decimal priceDeliveryExpress = 0.00M;

            if (typeService == "standard" || typeService == "express")
            {
                if (weigthStuff < 1)
                    pricePerKm += 0.03M;
                else if (weigthStuff >= 1 && weigthStuff <= 10)
                    pricePerKm += 0.05M;
                else if (weigthStuff >= 11 && weigthStuff <= 40)
                    pricePerKm += 0.10M;
                else if (weigthStuff >= 41 && weigthStuff <= 90)
                    pricePerKm += 0.15M;
                else if (weigthStuff >= 91 && weigthStuff <= 150)
                    pricePerKm += 0.20M;
            }
            
            if (typeService == "express")
            {
                if (weigthStuff < 1)
                    moreExp = weigthStuff * (pricePerKm * 0.80M);
                else if (weigthStuff >= 1 && weigthStuff <= 10)
                    moreExp = weigthStuff * (pricePerKm * 0.40M);
                else if (weigthStuff >= 11 && weigthStuff <= 40)
                    moreExp = weigthStuff * (pricePerKm * 0.05M);
                else if (weigthStuff >= 41 && weigthStuff <= 90)
                    moreExp = weigthStuff * (pricePerKm * 0.02M);
                else if (weigthStuff >= 91 && weigthStuff <= 150)
                    moreExp = weigthStuff * (pricePerKm * 0.01M);
            }

            priceDelivery = distance * pricePerKm;

            if (typeService == "express")   
                priceDeliveryExpress = (distance * moreExp) + priceDelivery;

            if (typeService == "standard")
            Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", weigthStuff, priceDelivery);
            else 
            Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", weigthStuff, priceDeliveryExpress);

        }
    }
}
