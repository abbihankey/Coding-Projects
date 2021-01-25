using System;
using static System.Console;

namespace StateAreaCodes
{
    class Program
    {
        public static bool Search(int input)
        {
            Code[] code = new Code[] { (Code)48875, (Code)48876, (Code)48877};
            WriteLine(code); //overides tostring
            int index = Array.BinarySearch(code, input); //"System.InvalidOperationException: 'Failed to compare two elements in the array.'"
                                                         // both code and input are int. I have no idea why i'm getting this exeption or how to handle it
            if (index > 0)
            {
                return false;
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            //get user inpt and send to search method
            int input;
            string inputString;
            bool searchResults;
            Write("Please enter the a code to search: ");
            inputString = ReadLine();
            while (int.TryParse(inputString, out input) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter an integer value. ");
                inputString = ReadLine();
            }
            searchResults = Search(input);
            if (searchResults == true)
            {
                WriteLine("Area Code Found!");
            }
            else
            {
                WriteLine("Area Code Not Found!");
            }  
        }  
    }
}
