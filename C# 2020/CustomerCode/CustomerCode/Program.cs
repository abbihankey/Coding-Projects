using System;
using static System.Console;

namespace CustomerCode
{
    class Program
    {   // Abagail Hankey
        // Intro to C#: Ch.8 E.4
        // W9 GEa
        // 7/15/20
        // This programs uses an array to store and print info for a customer mailing label 
        static void Main(string[] args)
        {
            //def var
            string fName;
            string bDate;
            int mNumber;
            int zCode;

            GetDetails(out fName, out bDate, out mNumber, out zCode);
            Customer code = new Customer(fName, bDate, mNumber);
            WriteLine("Customer Code : {0}{1}{2}{3}", code.LastName, code.BirthYear % 100, code.PurchaseMonth, zCode % 100);
            WriteLine();
            ReadKey();
        }
        public static void GetDetails(out string fName, out string bDate, out int mNumber, out int zCode)
        {

            WriteLine("Customer Application");
            WriteLine("----------------------------------------------------------------------");
            WriteLine();
            Write("Name (FirstName LastName): ");
            fName = ReadLine();

            Write("Birthdate (mm/dd/yyyy): ");
            bDate = ReadLine();

            Write("Subscription purchased (Month Number): ");
            mNumber = int.Parse(ReadLine());

            Write("Customer ZipCode (12345): ");
            zCode = int.Parse(ReadLine());

        }
    }
}
        
