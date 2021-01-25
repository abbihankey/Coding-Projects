using System;
using static System.Console;

namespace AverageGradeCalc
{
    class Program
    {   // Abagail Hankey
        // Intro to C#, Assignment 5, CH.6 E.4
        // This program calculates grade average using a sentinal loop
        public static void Main(string[] args)
        {
            //def variables
            string scoresInput = "0";
            int scores = 0;
            double average = 0;
            int count = 0;
            int scoresTotal =0;
            
            //Menu
            WriteLine("Average Grade Calculator");
            WriteLine("--------------------------------------------------------");
            WriteLine("Please input your scores one at a time:  ");
            scoresInput = ReadLine();

            //sentinal loop
            while (scoresInput.Equals("-99") == false)
            {
                //try parse
                while ((int.TryParse(scoresInput, out scores) == false))
                {
                    WriteLine("Invalid input, please re-enter scores: ");
                    scoresInput = ReadLine();
                }
                count++;
                scoresTotal += scores;

                WriteLine("Input next score or -99 to quit: ");
                scoresInput = ReadLine();
                
                while ((int.TryParse(scoresInput, out scores) == false))
                {
                    WriteLine("Invalid input, please re-enters scores: ");
                    scoresInput = ReadLine();
                }
            }

            average = scoresTotal / count;

            if (average >= 90)
            {
                WriteLine("Letter Grade: A");
            }
            else if ((average >= 80) && (average <= 89))
            {
                WriteLine("Letter Grade: B");
            }
            else if ((average >= 70) && (average <= 79))
            {
                WriteLine("Letter Grade: C");
            }
            else if ((average >= 60) && (average <= 69))
            {
                WriteLine("Letter Grade: D");
            }
            else
            {
                WriteLine("Letter Grade: F");
            }
            ReadKey();
        }
    }
}
