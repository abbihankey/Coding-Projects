using System;
using static System.Console;
using System.Linq;

namespace MonthlySalesContributions
{
    class Program
    {   // Abagail Hankey
        // Intro to C#: W7 GE
        // Ch.7, E.5
        // This program ouputs sales and contribution percentages using an array
        // 7/1/2020
        static void Main(string[] args)
        {
            //def variables
            double total = 0;
            string saleInput;
            int saleCount = 0;
            double contributionPercent;
            //initialize array
            double[] sale = new double[100];
            //Get input
            WriteLine("Ion Sales Corporation Monthly Sales Contribution ");
            WriteLine("----------------------------------------------------------------------\n");
            Write("Enter Sale {0}: ((-99 to exit)) ", saleCount + 1);
            saleInput = ReadLine();
            while (saleInput != "-99")
            {
                if (double.TryParse(saleInput, out sale[saleCount]) == false)
                    WriteLine("Invalid data −" + "0 stored in array");
                ++saleCount;
                Write("Enter Sale {0}: ((-99 to exit)) ", saleCount + 1);
                saleInput = ReadLine();
            }
            for (int i = 0; i < sale.Length; i++)
            {
                total += sale[i]; 
            }
            WriteLine(" ");
            WriteLine("Sale\tContribution Percentage");
            for (int i = 0; i < sale.Length; i++)
            {
                contributionPercent = (sale[i] / total);
                
                if (sale[i] != 0) 
                {
                    WriteLine("{0}\t\t{1:P}", sale[i], contributionPercent);
                }  
            }
            ReadKey();
        }
    }   
}
