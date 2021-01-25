// Abagail Hankey
// Intro To C# Group Exercise Week 2 (Ch.2, Programing Exercise 8)
// 5/29/2020
// This prgram calculates the weighted average of grades from user input. 
//

using System;
using static System.Console;

namespace WeightedGradeAverageCalc_W2GE_
{
    class Program
    {
        static void Main(string[] arg)
        {


            //Establish constants (weight)
            const double HOMEWORK_WEIGHT = .10;
            const double PROJECT_WEIGHT = .35;
            const double QUIZ_WEIGHT = .10;
            const double EXAM_WEIGHT = .30;
            const double FINAL_EXAM_WEIGHT = .15;

            //Establish variables
            int homeworkGrade;
            int projectGrade;
            int quizGrade;
            int examGrade;
            int finalExamGrade;

            //Print Weight
            WriteLine("GRADE WEIGHT:");
            WriteLine("Homework: {0:P}", HOMEWORK_WEIGHT);
            WriteLine("Project: {0:P}", PROJECT_WEIGHT);
            WriteLine("Quiz: {0:P}", QUIZ_WEIGHT);
            WriteLine("Exam: {0:P}", EXAM_WEIGHT);
            WriteLine("Final Exam: {0:P}", FINAL_EXAM_WEIGHT);
            WriteLine("  ");

            
            
            //Get input
            WriteLine("To calculate the weighted average of your grade, please enter your scores: ");
            WriteLine("Homework Grade: ");
            string homeworkInput = ReadLine();
            homeworkGrade = int.Parse(homeworkInput);

            WriteLine("Project Grade: ");
            string projectInput = ReadLine();
            projectGrade = int.Parse(projectInput);

            WriteLine("Quiz Grade: ");
            string quizInput = ReadLine();
            quizGrade = int.Parse(quizInput);

            WriteLine("Exam Grade: ");
            string examInput = ReadLine();
            examGrade = int.Parse(examInput);

            WriteLine("Final Exam Grade: ");
            string finalExamInput = ReadLine();
            finalExamGrade = int.Parse(finalExamInput);

            WriteLine(" ");

            //Calculate
            double weightedAverage = (HOMEWORK_WEIGHT * (homeworkGrade)) + (PROJECT_WEIGHT * (projectGrade)) + (QUIZ_WEIGHT * (quizGrade)) + (EXAM_WEIGHT * (examGrade)) + (FINAL_EXAM_WEIGHT * (finalExamGrade));

            //Print results


            WriteLine("WEIGHTED AVERAGE GRADE: {0:F2} %", weightedAverage);


            ReadKey();






        }
    }
}
