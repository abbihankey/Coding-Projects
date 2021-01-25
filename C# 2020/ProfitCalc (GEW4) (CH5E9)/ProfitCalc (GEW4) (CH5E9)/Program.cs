using System;
using static System.Console;
// Abagail Hankey
// Intro to C#, Chapter 5 Exercise 9
// 6-11-2020
// This program calculates the profit an organization recieves based on sales.
namespace ProfitCalc__GEW4___CH5E9_
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Declare variables
            string salesString;
            string profitRatioString;
            decimal salesValue;
            decimal profitRatio;
            decimal profitValue;

            //Get user input
            WriteLine("\tSales Profit Calculator");
            Write("Please enter sales total (decimal value):");
            WriteLine("");
            salesString = ReadLine();
            while (decimal.TryParse(salesString, out salesValue) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter a postive, decimal value: ");
                salesString = ReadLine();
            }
            while (salesValue <= 0)
            {
                WriteLine("Invalid input");   
            }
         
            //Find profit ratio and sales
            if (salesValue <= 1000)
            {
                profitRatio = 0.03M;
                profitValue = profitRatio * salesValue;
                profitRatioString = profitRatio.ToString();
                WriteLine("Sales:        {0:C}", salesValue);
                WriteLine("Profit Ratio: {0:P}", profitRatioString);
                WriteLine("Profit:       {0:C}", profitValue);
            }
            else if ((salesValue >= 1000.01M) && (salesValue <= 5000))
            {
                profitRatio = 0.035M;
                profitValue = profitRatio * salesValue;

                WriteLine("Sales:        {0:C}", salesValue);
                WriteLine("Profit Ratio: {0:P}", profitRatio);
                WriteLine("Profit:       {0:C}", profitValue);
            }
            else if ((salesValue >= 5000.01M) && (salesValue <= 10000))
            {
                profitRatio = 0.04M;
                profitValue = profitRatio * salesValue;
                WriteLine("Sales:        {0:C}",salesValue);
                WriteLine("Profit Ratio: {0:P}", profitRatio);
                WriteLine("Profit:       {0:C}", profitValue);
            }
            else
            {
                profitRatio = 0.045M;
                profitValue = profitRatio * salesValue;
                WriteLine("Sales:        {0:C}",        salesValue);
                WriteLine("Profit Ratio: {0:P}", profitRatio);
                WriteLine("Profit:       {0:C}", profitValue);
            }
            return;
        }
    }
}