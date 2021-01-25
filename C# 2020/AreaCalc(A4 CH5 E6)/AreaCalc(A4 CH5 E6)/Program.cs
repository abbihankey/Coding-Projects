using System;
using static System.Console;
namespace AreaCalc_A4_CH5_E6_
{
    class Program
    { //Abagail Hankey
      //Into to C# Assignment 4: Ch.5, E.6
        static void Main(string[] args)
        { 
            //Call methods
            DisplayMenu();
            AreaCalc();
            ReadKey();
        }
        static public void DisplayMenu()
        {
            Write("\n\n");
            Write("Area Calculator:\n");
            Write("-------------------------------------------------------------------------");
            Write("\n\n");
        }
        static public void AreaCalc()
        {
            int radius;
            int length;
            int width;
            int height;
            double area = 0;
            int choice;
            string stringChoice;
            double pi = 3.14;

            Write("Input 1 for area of circle\n");
            Write("Input 2 for area of rectangle\n");
            Write("Input 3 for surface area of a cylinder\n");
            Write("Input your choice : ");
            stringChoice = ReadLine();
            while (int.TryParse(stringChoice, out choice) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter an 1, 2, or 3: ");
                stringChoice = ReadLine();
            }

            switch (choice)
            {
                case 1:
                    Write("Input radius of the circle: ");
                    radius = Convert.ToInt32(Console.ReadLine());
                    area = pi * radius * radius;
                    break;
                case 2:
                    Write("Input length of the rectangle: ");
                    length = Convert.ToInt32(Console.ReadLine());
                    Write("Input width of the rectangle: ");
                    width = Convert.ToInt32(Console.ReadLine());
                    area = length * width;
                    break;
                case 3:
                    Write("Input the radius of the cylinder: ");
                    radius = Convert.ToInt32(Console.ReadLine());
                    Write("Input the height of the cylinder: ");
                    height = Convert.ToInt32(Console.ReadLine());
                    area = 2 * pi * height +2 * pi * (Math.Pow(radius, 2));
                    break;
            }
            WriteLine("The area is : {0}", area);
        }
    }
}
