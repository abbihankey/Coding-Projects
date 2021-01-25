using System;
using static System.Console;

namespace ParkApp
{
    class Program
        // Abagail Hankey
        // Intro to C#
        // This program returns information on national and stateparks
    {
        static void Main(string[] args)
        {
            //def variables
            string inputFee;
            double fee;
            int numberOfEmployees;
            string inputNumberOfEmployees;
            string inputAnnualBudget;
            double annualBudget;
            string inputNumberOfVisitors;
            int numberOfVisitors;
 
            //create object
            Park park = new Park();

            Write("Please input name: ");
            park.Name = ReadLine();

            Write("Please input location: ");
            park.Location = ReadLine();

            Write("Please input facility type: ");
            park.FacilityType = ReadLine();

            Write("Please input available facilities: ");
            park.FacilitiesAvailable = ReadLine();
            

            //get fee input
            Write("Please input fee: ");
            inputFee = ReadLine();
            while (double.TryParse(inputFee, out fee) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter a double value. ");
                inputFee = ReadLine();
            }
            park.Fee = fee;

            //get number of employee input
            Write("Please input number of employees: ");
            inputNumberOfEmployees = ReadLine();
            while (int.TryParse(inputNumberOfEmployees, out numberOfEmployees) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter an integer value. ");
                inputNumberOfEmployees = ReadLine();
            }
            park.NumberOfEmployees = numberOfEmployees;

            //get annual budget
            Write("Please input annual budget: ");
            inputAnnualBudget = ReadLine();
            while (double.TryParse(inputAnnualBudget, out annualBudget) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter an double value. ");
                inputAnnualBudget = ReadLine();
            }
            park.AnnualBudget = annualBudget;

            //get number of visitors
            Write("Please input number of visitors: ");
            inputNumberOfVisitors = ReadLine();
            while (int.TryParse(inputNumberOfVisitors, out numberOfVisitors) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter an integer value. ");
                inputNumberOfVisitors = ReadLine();
            }
            park.NumberOfVisitors = numberOfVisitors;

            WriteLine("Name of park: " + park.Name + "\nLocation of park: " + park.Location + "\nType of park: " + park.FacilityType + "\nFacilities available:" + park.FacilitiesAvailable);

            WriteLine("Annual cost per visitor: " + park.CalculateCostPerVisitor());
            WriteLine("Revenue: " + park.CalculateRevenue());
            WriteLine();
            WriteLine(park.ToString());
        }
    }
}
