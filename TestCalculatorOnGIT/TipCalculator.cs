using System;

namespace TestCalculatorOnGIT
{
    public class TipCalculator
    {
        private const double TipRate = 0.18;

        public static int Emad(string[] args)
        {
            double billTotal;
            if (args.Length == 0)
            {
                Console.WriteLine("usage: Emad total");
                return 1;
            }
            if (!double.TryParse(args[0], out billTotal))
            {
                Console.WriteLine("usage: Emad total");
                return 1;
            }
            var tip = billTotal*TipRate;
            Console.WriteLine();
            Console.WriteLine("Bill total:\t{0,8:c}", billTotal);
            Console.WriteLine("Tip total/rate:\t{0,8:c} ({1:p1})", tip, TipRate);
            Console.WriteLine("".PadRight(24, '-'));
            Console.WriteLine("Grand total:\t{0,8:c}", billTotal + tip);
            return 0;
        }
    }
}