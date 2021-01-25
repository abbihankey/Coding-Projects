//Abagail Hankey, Ch.2, E7, A2. This program calculates tip amount. //
using System;
using static System.Console;

namespace TipCalculator 
{
    class Calculation
    {
        static void Main(string[] args)
        {
            const float FIFTEEN_VAL = .15f;
            const float TWENTY_VAL = .20f;

            WriteLine("Please input bill amount; ");
            double originalBill = Convert.ToDouble(ReadLine());


            double fifteenTip = originalBill * FIFTEEN_VAL;
            double twentyTip = originalBill * TWENTY_VAL;

            var fifteenTipPlusBill = fifteenTip + originalBill;
            var twentyTipPlusBill = twentyTip + originalBill;

            WriteLine(" ");
            WriteLine("Original Bill:                 {0:C}" , originalBill);
            WriteLine("Fifteen % Tip:                 {0:C}" , fifteenTip);
            WriteLine("Twenty % Tip:                  {0:C}" , twentyTip);
            WriteLine("Bill Total with Fifteen % Tip: {0:C}" , fifteenTipPlusBill);
            WriteLine("Bill Total with Twenty % Tip:  {0:C}" , twentyTipPlusBill);

            ReadKey();







        }
    }
}
