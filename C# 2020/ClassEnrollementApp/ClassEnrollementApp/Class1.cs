using System;
using System.Collections.Generic;
using System.Text;

namespace ClassEnrollementApp
{
    class Class
    {  // Abagail Hankey
       // Intro to C# Ch.7 E.10
       // 7/2/2020
       // This program displays class name and enrollment info

        string nameOfClass;
        int currentEnrol;
        int maxEnrol;
        int seatsLeft;

        // Default constructor
        public Class()
        {
        }
        // Constructor 
        public Class(string name, int current, int max)
        {
            nameOfClass = name;
            currentEnrol = current;
            maxEnrol = max; 
        }
        public string NameOfClass
        {
            get
            {
                return nameOfClass;
            }
            set
            {
                nameOfClass = value;
            }
        }
        public int CurrentEnrol
        {
            get
            {
                return currentEnrol;
            }
            set
            {
                currentEnrol  = value;
            }
        }
        public int MaxEnrol
        {
            get
            {
                return maxEnrol;
            }
            set
            {
                maxEnrol = value;
            }
        }
        public override string ToString( )
        {
            return "Class Name: " + nameOfClass  +  "\nMax Enrollment: " + maxEnrol + "\nCurrent Enrollment: " + currentEnrol;
        }
        public int CalcSeatsLeft()
        {
            seatsLeft = maxEnrol - currentEnrol;
            return seatsLeft;
        }
    }
}

