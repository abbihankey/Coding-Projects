using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_3
{
    class Student
    {
        public readonly string name;
        public readonly double[] grades;
        public Student(string name, double[] grades)
        {
            this.name = name;
            this.grades = grades;
        }
        public double getAverage()
        {
            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i]; 
            }
            return sum / (double)grades.Length;
        }
    }
}

