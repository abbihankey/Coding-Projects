using System;
using static System.Console;

namespace WaterDepth
{
    class Program
    {   // Abagail Hankey
        // Intro to C#: Ch.8 E.10
        // Assignment 8
        // 7/16/2020
        // This program uses an array to store and display data on water depth
        static void Main(string[] args)
        {
            double[,] waterDepth = new double[6, 5];
            string[] location = {"Surf City", "Solomons", "Hilton Head", "Miami", "Savannah"};
            string[] recordingTime = { "0700 (7am)", "1200 (noon)", "1700 (5pm)", "2100 (9pm)" };

            InitializeArray(waterDepth);
            GetWaterDepths(waterDepth, location, recordingTime);
            FindAverageDepthByLocation(waterDepth);
            FindAverageDepthByTime(waterDepth);
            DisplayTable(waterDepth, location, recordingTime);
            ReadKey();
        }

        public static void InitializeArray(double[,] sales)
        {
            Array.Clear(sales, 0, sales.Length);
        }

        public static void GetWaterDepths(double[,] waterDepth, string[] location, string[] recordingTime)
        {
            int locNum, recTime;
            string inputValue;
            bool moreData = true;
            while (moreData == true)
            {
                locNum = GetLocationNumber(location);
                recTime = GetRecTimeNum(recordingTime);
                waterDepth[locNum, recTime] = GetWaterDepths();
                Write("\n\nIs there more depths to record? (y/n): ");
                inputValue = ReadLine();
                switch (inputValue)
                {
                    case "n":
                    case "N":
                        moreData = false;
                        break;
                    default:
                        moreData = true;
                        break;
                }
            }
        }
        public static int GetLocationNumber(string[] location)
        {
            int locNum = -1;
            WriteLine("Available Locations:");
            for (int i = 0; i < location.Length; i++)
            {
                WriteLine((i + 1) + ". " + location[i]);
            }
            Write("Enter Location Number: ");
            locNum = Convert.ToInt32(ReadLine());
            WriteLine("");
            return locNum;
        }
        public static int GetRecTimeNum(string[] recordingTime)
        {
            int recTime = -1;
            WriteLine("Applicable Recording Times:");
            for (int i = 0; i < recordingTime.Length; i++)
            {
                WriteLine((i + 1) + ". " + recordingTime[i]);
            }
            Write("Enter Recording Time: ");
            recTime = Convert.ToInt32(ReadLine());
            return recTime;
        }
        public static double GetWaterDepths()
        {
            double depth = 0.0;
            Write("Enter depth of water: ");
            depth = Convert.ToDouble(ReadLine());
            return depth;
        }
        public static void DisplayTable(double[,] waterDepth, string[] location, string[] recordingTime)
        {
            WriteLine("Location\tAverage Depth");
            for (int i = 1; i < waterDepth.GetLength(0); i++)
            {
                WriteLine(i + ". " + location[i - 1] + "\t" + waterDepth[i, 0]);
            }
            WriteLine("Recording Time\tAverage Depth");
            for (int i = 1; i < waterDepth.GetLength(1); i++)
            {
                WriteLine(i + ". " + recordingTime[i - 1] + "\t" + waterDepth[0, i]);
            }
        }
        public static void FindAverageDepthByLocation(double[,] waterDepth)
        {
            int countOfActualData = 0;
            double total = 0;
            for (int row = 1; row < waterDepth.GetLength(0); row++)
            {
                for (int column = 1; column < waterDepth.GetLength(1); column++)
                {
                    if (waterDepth[row, column] > 0)
                    {
                        total += waterDepth[row, column];
                        countOfActualData++;
                    }
                }
                if (countOfActualData != 0)
                {
                    waterDepth[row, 0] = total / countOfActualData;    // Store average in column zero
                    total = 0;
                    countOfActualData = 0;
                }
                else
                    waterDepth[row, 0] = 0;
            }
        }
        public static void FindAverageDepthByTime(double[,] waterDepth)
        {
            int countOfActualData = 0;
            double total = 0;
            for (int column = 1; column < waterDepth.GetLength(1); column++)
            {
                for (int row = 1; row < waterDepth.GetLength(0); row++)
                {
                    if (waterDepth[row, column] > 0)
                    {
                        total += waterDepth[row, column];
                        countOfActualData++;
                    }
                }
                if (countOfActualData != 0)
                {
                    waterDepth[0, column] = total / countOfActualData;    // Store average in row zero
                    total = 0;
                    countOfActualData = 0;
                }
                else
                    waterDepth[0, column] = 0;
            }
        }
    }
}
   
