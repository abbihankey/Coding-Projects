using System;
using static System.Console;

namespace DateDisplayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            int month;
            int year;

            Write("Please enter the day: ");
            string dayInput = ReadLine();
            while (int.TryParse(dayInput, out day) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter an integer value. ");
                dayInput = ReadLine();
            }
            Write("Please enter the month: ");
            string monthInput = ReadLine();
            while (int.TryParse(monthInput, out month) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter an integer value. ");
                monthInput = ReadLine();
            }
            Write("Please enter the year: ");
            string yearInput = ReadLine();
            while (int.TryParse(yearInput, out year) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter an integer value. ");
                yearInput = ReadLine();
            }

            //create new object

            Date date = new Date(day, month, year);

            WriteLine(date);  // This will automatically run the object's ToString() method.

            ReadLine();  // Pause the program
        }
    }
}
