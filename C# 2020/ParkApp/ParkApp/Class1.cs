using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ParkApp
{
    class Park
    {
        //define variables
        double costPerVisitor;
        double revenue;

        //get sets 
        public double AnnualBudget { get; set; }
        public double NumberOfVisitors { get; set; }
        public string Name { get; set; }   
        public string Location { get; set; }
        public string FacilityType { get; set; }
        public string FacilitiesAvailable { get; set; }
        public double Fee { get; set; }
        public int NumberOfEmployees { get; set; }
        public double CalculateCostPerVisitor()
        {
            this.costPerVisitor = this.AnnualBudget / this.NumberOfVisitors;
            return this.costPerVisitor;
        }
        public double CalculateRevenue()
        {
            this.revenue = this.NumberOfVisitors * this.Fee;
            return this.revenue;
        }

        public override string ToString()
        {
            string sOutput = "Name of park: " + this.Name + "\nLocation: " + this.Location + "\nFacility Type: " + this.FacilityType + "\nFacility Fee: " + this.Fee + "\nNumber of employees: " + this.NumberOfEmployees +
                "\nNumber of visitors recorded in the past 12 months: " + this.NumberOfVisitors + "\nAnnual Budget: " + this.AnnualBudget;
            return sOutput;
        }
    }
}
    

