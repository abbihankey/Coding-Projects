using System;
using static System.Console;

namespace ComputerClubEarnings_GE_W3___CH3_E8_
{
    class Program
    {
        private static void Main(string[] args)
        {
            string casesSoldInput;
            int casesSold;
            double totalRevenue;
            double pricePerBar;
            string pricePerBarInput;
            const double CASE_COST = 5.00;
            double totalExpenses;
            const double STUDENT_GOVERNMENT_CUT_PERCENT = .10;
            double profitBeforeCut;
            double totalProfit;
            double studentGovernmentCut;

            WriteLine("Please input number of cases sold: ");
            casesSoldInput = ReadLine();
            casesSold = Int32.Parse(casesSoldInput);
            if ((int.TryParse(casesSoldInput, out casesSold)) == false)
            {
                WriteLine("Please enter valid input: ");
            }

            WriteLine("Please input price per bar: ");
            pricePerBarInput = ReadLine();
            if ((double.TryParse(pricePerBarInput, out pricePerBar)) == false)
            {
                WriteLine("Please enter valid input: ");
            }
            
            pricePerBar = double.Parse(pricePerBarInput);
            
            totalExpenses = CalcExpenses(casesSold, CASE_COST);
            totalRevenue = CalcRevenue(casesSold, pricePerBar);

            profitBeforeCut = totalRevenue - totalExpenses;
            studentGovernmentCut = profitBeforeCut * STUDENT_GOVERNMENT_CUT_PERCENT;
            totalProfit = profitBeforeCut - studentGovernmentCut;


            WriteLine("Total Revenue: {0:C}", totalRevenue);
            WriteLine("Total Expenses: {0:C}", totalExpenses);
            WriteLine("Total Profit: {0:C}", totalProfit);

            static double CalcRevenue(int casesSold, double pricePerBar)
            {
                int numOfBars;

                const int BARS_PER_CASE = 12;
                numOfBars = casesSold * BARS_PER_CASE;
                
                return numOfBars * pricePerBar;
            }
            static double CalcExpenses(int casesSold, double CASE_COST)
            { 
                return casesSold * CASE_COST; 
            }

                 

        }
    }
}
