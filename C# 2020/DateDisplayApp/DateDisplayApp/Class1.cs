using System;
using System.Collections.Generic;
using System.Text;

namespace DateDisplayApp
{
    class Date
    {   //get sets
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string MonthName { get; set; }

        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }
        public void ConvertMonth()
        {
            switch (this.Month)
            {
                case 1:
                    this.MonthName = "January";
                    break;
                case 2:
                    this.MonthName = "February";
                    break;
                case 3:
                    this.MonthName = "March";
                    break;
                case 4:
                    this.MonthName = "April";
                    break;
                case 5:
                    this.MonthName = "May";
                    break;
                case 6:
                    this.MonthName = "June";
                    break;
                case 7:
                    this.MonthName = "July";
                    break;
                case 8:
                    this.MonthName = "August";
                    break;
                case 9:
                    this.MonthName = "September";
                    break;
                case 10:
                    this.MonthName = "October";
                    break;
                case 11:
                    this.MonthName = "November";
                    break;
                case 12:
                    this.MonthName = "December";
                    break;
                default:
                    this.MonthName = "Invalid Month";
                    break;
        }   }
        public override string ToString()
        {
            this.ConvertMonth(); // Write a method to convert the month number to a month name

            string sOutput = "\n\nDate: " + this.MonthName + " " + this.Day + ", " + this.Year + "\n\n";

            return sOutput;  // ToString has to return a string
        }


    }

}
