using System;
using static System.Console;

namespace ActivityRecomendation
{
    class Program
    {
        static int Main(string[] args)
        {
            string tempString;
            int temp;
            char tempValue;
            char weatherValue;
            string weatherString;

            WriteLine("Please enter tempature: ");
            tempString = ReadLine();
            if (int.TryParse(tempString, out temp) == false)
            {
                WriteLine("Invalid input");
            }
            return temp;

            WriteLine("Please enter weather P for rain/snow, S for sunny, O for cloudy: ");
            weatherString = ReadLine();
            if (char.TryParse(weatherString, out weatherValue) == false)
                WriteLine("Invalid input");

            ConvertTemp();
            RecomendActivity();


            static int ConvertTemp(string stringTemp, int temp, char tempValue);
            {
                 switch (temp)
                 {
                    case temp > 73:
                        tempValue = 'H';
                        break;
                    case temp < 61:
                        tempValue = 'C';
                        break;
                    default:
                        tempValue = 'M';
                        break;
                 }
                return tempValue;
           
            }

            static int RecomendActivity();
                if (tempValue = 'H') & (weatherValue = 'P')
                 {
                    WriteLine("Soccer");
                 }
                if (tempValue = 'H') & (weatherValue = 'S')
                 {
                    WriteLine("Soccer");
                 }
                
                if (tempValue = 'H') & (weatherValue = 'O')
                    WriteLine("Baseball");

                if (tempValue = 'M') & (weatherValue = 'P')
                    WriteLine("Indoor Basketball");

                if (tempValue = 'M') & (weatherValue = 'S')
                    WriteLine("Tennis");

                if (tempValue = 'M') &(weatherValue = 'O')
                 {
                    WriteLine("Outddor Basketball");
                 }
                if (tempValue = 'C') &(weatherValue = 'P')
                 {
                    WriteLine("Sledding");
                 }
                if (tempValue = 'C') &(weatherValue = 'S')
                 {
                    WriteLine("Running");
                 }
                if (tempValue = 'H') &(weatherValue = 'P')
                 {
                    WriteLine("Hockey");
                 }

        }
    }
}
