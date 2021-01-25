// Abagail Hankey, Ch.1, E6, This program displays output 3 ways. Includes a line from one of my favorite episodes of the Simpsons, Bart v Australia //

using System;
using static System.Console;


namespace OutputThreeWays_CH1__E6_
{
    class Output
    {
        static void Main(string[] args)
        {
            BackgroundColor = ConsoleColor.White;
            Clear();
            ForegroundColor = ConsoleColor.Black;


            WriteLine("Output #1");
            Write("\tI see " );
            Write("you've played ");
            Write("knifey-spooney before.");
            WriteLine(" ");
            WriteLine(" ");

            WriteLine("Output #2");
            Write("\tI see\n");
            Write("\tyou've played\n ");
            Write("\tknifey-spooney before.\n");
            WriteLine(" ");

            WriteLine("Output #3");
            WriteLine("\tI\n \tsee\n \tyou've\n \tplayed\n \tknifey-\n \tspooney\n \tbefore.\n");
            WriteLine(" ");
            
            Write("Press any key to continue");
            ReadKey();





        }
    }
}
