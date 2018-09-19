using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoPictures
{
    class Program
    {
        static void Main(string[] args)
        {
            double pictures = double.Parse(Console.ReadLine());
            string sizePictures = Console.ReadLine().ToLower();
            string typeOrder = Console.ReadLine().ToLower();

            double sumOrder = 0;
            double pricePic = 0;

            switch (sizePictures)
            {
                case "9x13": pricePic += 0.16; break;
                case "10x15": pricePic += 0.16; break;
                case "13x18": pricePic += 0.38; break;
                case "20x30": pricePic += 2.90; break;
            }

            if (sizePictures == "9x13" && pictures >= 50)
                pricePic = pricePic - (pricePic * 0.05);
            else if (sizePictures == "10x15" && pictures >= 80)
                pricePic = pricePic - (pricePic * 0.03);
            else if (sizePictures == "13x18" && pictures >= 50 && pictures <= 100)
                pricePic = pricePic - (pricePic * 0.03);
            else if (sizePictures == "13x18" && pictures > 100)
                pricePic = pricePic - (pricePic * 0.05);
            else if (sizePictures == "20x30" && pictures >= 10 && pictures <= 50)
                pricePic = pricePic - (pricePic * 0.07);
            else if (sizePictures == "20x30" && pictures > 50)
                pricePic = pricePic - (pricePic * 0.09);

            if (typeOrder == "online")
                pricePic = pricePic - (pricePic * 0.02);

            sumOrder = pricePic * pictures;

            Console.WriteLine("{0:f2}BGN", sumOrder);
        }
    }
}
