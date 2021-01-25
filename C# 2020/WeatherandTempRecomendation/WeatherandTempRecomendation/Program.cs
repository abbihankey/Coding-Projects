using System;
using static System.Console;

namespace WeatherandTempRecomendation
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempInput;
            int temp;
            char tempChar;
            string weatherInput;
            char weatherChar;

            //Get temp and parse
            WriteLine("Please input temp: ");
            tempInput = ReadLine();
            if ((int.TryParse(tempInput, out temp)) == false)
            {
                WriteLine("Please input valid temp: "); 
            }
            temp = int.Parse(tempInput);
            

            //Get weather and parse
            WriteLine("Please input weather (P for rain or snow, S for sunny and O for cloudy: ");
            weatherInput = ReadLine();
            if ((char.TryParse(weatherInput, out weatherChar)) == false)
            {
                WriteLine("Please input valid weather: ");
            }
            weatherChar = char.Parse(weatherInput);
            
            //call methods
            tempChar = ConvertTemp(temp);
            RecommendActivity(tempChar, weatherChar);

            static void RecommendActivity(char tempChar, char weatherChar)
            {

                if ('H'.Equals(tempChar))
                {
                    if ('P'.Equals(weatherChar))
                    {
                        WriteLine("Activity Recommendation: Soccer");
                    }
                    else if ('S'.Equals(weatherChar))
                    {
                        WriteLine("Activity Recommendation: Swimming");
                    }
                    else
                        WriteLine("Activity Recommendation: Baseball");
                }
                
                if ('M'.Equals(tempChar))
                {
                        if ('P'.Equals(weatherChar))
                        {
                            WriteLine("Activity Recommendation: Indoor basketball");
                        }
                        else if ('S'.Equals(weatherChar))
                        {
                            WriteLine("Activity Recommendation: Tennis");
                        }
                        else
                        {
                            WriteLine("Activity Recommendation: Outdoor Basketball");
                        }        
                }

                if ('C'.Equals(tempChar))
                {
                    if ('P'.Equals(weatherChar))
                    {
                        WriteLine("Activity Recommendation: Sledding");
                    }
                    else if ('S'.Equals(weatherChar))
                    {
                        WriteLine("Activity Recommendation: Running");
                    }
                    else
                    {
                        WriteLine("Activity Recommendation: Hockey");
                    }
                }
            }

            static char ConvertTemp(int temp)
            {   char tempConvert;
                if (temp > 72)
                {
                    tempConvert = 'H';
                }
                else if (temp < 60)
                {
                    tempConvert = 'C';
                } 
                else
                {   tempConvert = 'M';
                }
                return tempConvert;
            }


        }
    }
}
