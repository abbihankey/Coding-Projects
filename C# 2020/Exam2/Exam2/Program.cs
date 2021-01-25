using System;
using static System.Console;

namespace Exam2
{
    class Program
    {
        public static void Draw(int height, int width) //how in the world do you do this with different symbols in defferent spots??
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if ((i == 1 || i == height) || (j == 1 || j == width))
                        Write("+");
                    else
                        Write(" ");
                }
                WriteLine();
        }   }    
        static void Main(string[] args)
        {
            int height;
            int width;
            string yesOrNo;

            WriteLine("Would you like to print a rectangle? (y/n): ");
            yesOrNo = ReadLine();

            do
            {
                Write("Enter Height: ");
                height = int.Parse(ReadLine());

                Write("Enter Width: ");
                width = int.Parse(ReadLine());

                Rectangle rectangleObj = new Rectangle(height, width); //when removing object initiation program runs fine
                
                Draw(height, width); // How do I pass rectangleObj here? 

            } while (yesOrNo != "y");
        }
    }
}
