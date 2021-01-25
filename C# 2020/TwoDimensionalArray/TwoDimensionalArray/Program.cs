using System;
using static System.Console;

namespace TwoDimensionalArray
{
    class Program
    {   // Abagail Hankey
        // Intro to C#: CH.8 E.6
        // W9 GEb
        // 7/16/2020
        // This program creates and fills a two dimensional array with random numbers and returns the largest value and it's index
        static void Main(string[] args)
        {
            int maxi = 0; 
            int maxj = 0;
             
            Random random = new Random();

            WriteLine("Enter the number of rows: ");
            int rows = Convert.ToInt32(ReadLine());

            WriteLine("Enter the number of columns: ");
            int columns = Convert.ToInt32(ReadLine());
            
            int[,] randomarray = new int[rows, columns];
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    randomarray[i, j] = random.Next(0, 100);
                }
            }
            int max = randomarray[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Write("\n[" + i + "," + j + "]" + "\t");
                    Write(randomarray[i, j]);
                }
                WriteLine("\n");
            }
             
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (randomarray[i, j] > max)
                    {
                        max = randomarray[i, j];
                        maxi = i;
                        maxj = j;
                    }
                }
            }
            WriteLine("The largest value is stored at [" + maxi + "," + maxj + "] " + max);
            ReadKey();
        }
    }
}  
    
