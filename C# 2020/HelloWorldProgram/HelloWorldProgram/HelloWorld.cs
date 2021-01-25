// Abagail Hankey, Chapter 1, Exercise 1 //
// This program prints "Hello World" and my introduction // 


using System;
using static System.Console;

namespace HelloWorldProgram
{
    class HelloWorld
    {
        static void Main()
        {
            BackgroundColor = ConsoleColor.White;
            Clear();
            ForegroundColor = ConsoleColor.Black; 
            
            WriteLine("Hello World!");
            WriteLine("I am Abbi Hankey and this is my first C# program.");
            ReadKey();
            
            
            

        }
    }
}

