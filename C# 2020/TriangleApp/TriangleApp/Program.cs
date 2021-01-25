using System;
using static System.Console;

namespace TriangleApp
{
    class Program
    {   // Abagail Hankey
        // 
        static void Main(string[] args)
        {
            //def variables
            char character;
            string characterInput;
            int peak;
            string peakInput;

            //Menu
            WriteLine("Isosceles Triangle Application");
            WriteLine("--------------------------------------------------------------------");

            //get character input
            Write("Please input a character: ");
            characterInput = ReadLine();
            while (char.TryParse(characterInput, out character) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter a character. ");
                characterInput = ReadLine();
            }
            
            //get peak input
            Write("Enter a peak value (any value greater than 10 defaults as 3): ");
            peakInput = ReadLine();
            while (int.TryParse(peakInput, out peak) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter an integer value. ");
                peakInput = ReadLine();
            }
            //make sure peak isn't greater than 10
            while (peak > 10)
            {
                peak = 3;
            }
            //print triangle
            for (int row = 0; row < peak; row++)
            {
                Console.WriteLine(new string(character, row + 1));
            }
            for (int row = 1; row < peak; row++)
            {
                Console.WriteLine(new string(character, peak - row));
            }
            ReadKey();





        }

    }
}
