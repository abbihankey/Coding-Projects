using System;
using static System.Console;
namespace PropertyTaxCalc_A3_
{
    class Program
    {   //************************************************************************************//
        // Abagail Hankey
        // 6/6/2020
        // Intro to C# - Assignment 3
        // 
        // This program calculates property taxes
        //
        //************************************************************************************//
        private static void Main()
        {
            //Establish constants
            const double TOWNSHIP_INCREASE = .027;
            const double EXEMPTION = 25000;
            const double MILLAGE_RATE = 10.03;
            const double MILLAGE_RATE_DIVISOR = 1000;
            //Establish Variables
            string propertyAddress;
            string assessedValInput;
            double priorAssessedVal;
            double newAssessedVal;
            double assessedValWithExemption;
            double townshipValIncrease;
            //Get input
            WriteLine("Please input your address: ");
            propertyAddress = ReadLine();
            WriteLine("Please input the prior years assessed value of the property: ");
            assessedValInput = ReadLine();
            priorAssessedVal = double.Parse(assessedValInput);
            //Calculate New Val
            townshipValIncrease = priorAssessedVal * TOWNSHIP_INCREASE;
            newAssessedVal = townshipValIncrease + priorAssessedVal;
            //Subtract Exemption
            assessedValWithExemption = (newAssessedVal) - (EXEMPTION);
            //Call method
            double propertyTax = CalcPropertyTaxes(assessedValWithExemption, MILLAGE_RATE_DIVISOR, MILLAGE_RATE);
            //Display info
            WriteLine("                  Property Assessment App\n");
            WriteLine("{0}{1:C}\n", "Street Address: ", propertyAddress);
            WriteLine("{0}{1,30:C}\n", "Last Year Assessed Value:  ", priorAssessedVal);
            WriteLine("{0}{1,30:c}", "Current Assessed Value:    ", newAssessedVal);
            WriteLine("{0}{1,30:c}", "Exemption:                 ", EXEMPTION);
            WriteLine("{0}{1,30:c}", "Taxable Value:             ", assessedValWithExemption);
            WriteLine("{0}{1,30:c}\n", "Millage Rate (per $1000):  ", MILLAGE_RATE);
            PrintPropertyTax(propertyTax);
            WriteLine("\nPress any key to exit the program.");
            ReadLine();
        }
        //Define methods
        static double CalcPropertyTaxes(double assessedValWithExemption, double MILLAGE_RATE_DIVISOR, double MILLAGE_RATE)
        {
            return (assessedValWithExemption / MILLAGE_RATE_DIVISOR) * MILLAGE_RATE;
        }
        static void PrintPropertyTax(double propertyTax)
        {
           WriteLine("{0}{1,30:c}", "Taxable Value:             ", propertyTax);
            
        }
    }
}
