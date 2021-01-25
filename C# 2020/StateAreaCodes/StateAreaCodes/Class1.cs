using System;
using System.Collections.Generic;
using System.Text;

namespace StateAreaCodes
{   // Abagail Hankey
    // Intro to C# - Ch.7 E.7
    // 7-8-20
    // This program searchs an array of area codes
    public class Code
    {
        int code;
        int areaCode;

        // Default constructor
        public Code()
        {
        }

        public Code(int code)
        {
            areaCode = code;
        }

        public static explicit operator Code(int code)
        {
            return new Code(code);
        }
        public override string ToString()
        {
            string sOutput = "(" + this.areaCode + ")\n";

            return sOutput;  // ToString has to return a string
        }
    }
}
