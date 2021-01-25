using System;
using static System.Console;

namespace ClassEnrollementApp
{
    class Program
    { // Abagail Hankey
      // Intro to C# Ch.7 E.10
      // 7/2/2020
      // This program displays class name and enrollment info
        public static void GetClassInfo(out string name, out int max, out int current)
        {
            string maxInput;
            string currentInput;
            
            WriteLine();
            Write("Class Name: ");
            name = ReadLine();
            Write("Class Maximum Enrollment: ");
            maxInput = ReadLine();
            while (int.TryParse(maxInput, out max) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter an integer value. ");
                maxInput = ReadLine();
            }
            Write("Class Current Enrollment: ");
            currentInput = ReadLine();
            while (int.TryParse(currentInput, out current) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter an integer value. ");
                currentInput = ReadLine();
            }
        }
        static void Main(string[] args)
        {
            //def variables
            string name;
            int current;
            int max;
            string classNumberInput;
            int classCount;
            int loopCount = 0;

            WriteLine("How many classes?: ");
            classNumberInput = ReadLine();
            if (int.TryParse(classNumberInput, out classCount) == false)
                WriteLine("Invalid data entered − 0 recorded for number of classes");
            
            Class[] classObj = new Class[classCount];
            while (loopCount < classCount)
            {
                GetClassInfo(out name, out max, out current);
                classObj[loopCount] = new Class(name, current, max);
                ToString(classObj[loopCount]);
                loopCount++;
            }
            ReadKey();
        }

    }
    
}
