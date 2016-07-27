using System;

namespace Tipping
{
    public class TippingTable
    {
        private static void Main(string[] args)
        {
            var dinnerPrice = 10.00;
            double tipRate;
            double tip;
            const double LOWRATE = 0.10;
            const double MAXRATE = 0.25;
            const double TIPSTEP = 0.05;
            const double MAXDINNER = 100.00;
            const double DINNERSTEP = 10.00;
            Console.Write("   Price");
            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
                Console.Write("{0, 8}", tipRate.ToString("P"));
            Console.WriteLine();
            const int NUM_DASHES = 40;
            for (var x = 0; x <= NUM_DASHES; ++x)
                Console.Write("-");
            Console.WriteLine();
            tipRate = LOWRATE;
            while (dinnerPrice <= MAXDINNER)
            {
                Console.Write("{0, 8}", dinnerPrice.ToString("C"));
                while (tipRate <= MAXRATE)
                {
                    tip = dinnerPrice*tipRate;
                    Console.Write("{0, 8}", tip.ToString("C"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += DINNERSTEP;
                tipRate = LOWRATE;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}