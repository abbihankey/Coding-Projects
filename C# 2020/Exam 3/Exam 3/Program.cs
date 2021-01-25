using System;
using System.Collections;
using static System.Console;

namespace Exam_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumberOfAssign;
            string yOrN = "N";
            ArrayList students = new ArrayList();
            Write("Enter total number of assignments: ");
            totalNumberOfAssign = Convert.ToInt32(ReadLine());
            do
            {
                Write("\nEnter student name : ");
                string name = ReadLine();
                double[] grades = new double[totalNumberOfAssign];
                for (int i = 0; i < totalNumberOfAssign; i++)
                {
                    Write("Enter student grade for assignment " + (i + 1) + " : ");
                    grades[i] = Convert.ToDouble(ReadLine()); 
                }
                Student student = new Student(name, grades); 
                students.Add(student);
                Write("Enter 'Y' to enter another student or 'N' to quit: ");
                yOrN = ReadLine(); 
            } while (yOrN == "Y");

            WriteLine();
            foreach (Student student in students)
            {
                WriteLine("Average Grade for " + student.name + " is " + Math.Round(student.getAverage(), 1)); 
            }

            WriteLine();

            for (int i = 0; i < totalNumberOfAssign; i++)
            {
                double assignSum = 0;
                foreach (Student student in students)
                {
                    assignSum += student.grades[i]; //calculate sum
                }
                double assignAverage = assignSum / (double)students.Count;
                WriteLine("Average Grade for assignment " + (i + 1) + " is : " + Math.Round(assignAverage, 1));
            }

        }
    }
}
 
