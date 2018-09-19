
namespace CurrencyConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            var bgCur = 1;
            var bgToUs = 1.79549;
            var bgToEu = 1.95583;
            var bgToGbp = 2.53405;

            var number = double.Parse(Console.ReadLine());

            var from = Console.ReadLine();
            var to = Console.ReadLine();

            if (from == "USD")
            {
                number = number * bgToUs;
            }
            else if (from == "EUR")
            {
                number = number * bgToEu;
            }
            else if (from == "GBP")
            {
                number = number * bgToGbp;
            }


            if (to == "USD")
            {
                number = number / bgToUs;
            }
            else if (to == "EUR")
            {
                number = number / bgToEu;
            }
            else if (to == "GBP")
            {
                number = number / bgToGbp;
            }
            Console.WriteLine(Math.Round(number, 2) + " " + to);
        }
    }
}
