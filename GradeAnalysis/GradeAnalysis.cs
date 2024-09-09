/* 
19) Create an algorithm that reads a student's name and two grades, 
calculates their average, and displays it on the screen. 
In the end, analyze the average and show whether 
the student had good performance (if it was above the average of 7.0).
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.GradeAnalysis
{
    public class GradeAnalysis
    {
        static void Main(string[] args)
        {
            Algorithm();
            PressEnterToExit();
        }

        public static void Algorithm()
        {
            Console.WriteLine("Enter the grade for exam 1:");
            double grade1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the grade for exam 2:");
            double grade2 = double.Parse(Console.ReadLine());

            double average = (grade1 + grade2) / 2;

            Console.WriteLine($"The average of the exams is equivalent to {average}");

            if (average >= 7)
            {
               Console.WriteLine("Student Passed !");
            }
            else
            {
                Console.WriteLine("Student Failed !");
            }
            
        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    
    }
}