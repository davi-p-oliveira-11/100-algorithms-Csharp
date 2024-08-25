/* 

5) Write a program that reads a student's two grades in a subject and displays their average in the course.

Example:
Grade 1: 4.5  
Grade 2: 8.5  
The average between 4.5 and 8.5 is 6.5
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.AverageOfTwo
{
    public class AverageOfTwo
    {
        
         static void Main(string[] args)
        {
            CalculateAverage();
            PressEnterToExit();
        }

        public static void CalculateAverage()
        {
           
           Console.WriteLine("Enter the grade of the first test:");
           double grade1 = double.Parse(Console.ReadLine());

           Console.WriteLine("Enter the grade of the second test:");
           double grade2 = double.Parse(Console.ReadLine());

           double average = (grade1 + grade2) / 2;

           Console.WriteLine($"The average between {grade1} and {grade2} is {average}");
        }


         public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
    }
}