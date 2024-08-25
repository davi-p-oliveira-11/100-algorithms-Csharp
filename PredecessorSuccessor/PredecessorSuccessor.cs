/* 
6) Write a program that reads an integer and displays its predecessor and successor.
Example:
Enter a number: 9
The predecessor of 9 is 8
The successor of 9 is 10
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.PredecessorSuccessor
{
    public class PredecessorSuccessor
    {
        
         static void Main(string[] args)
        {
            PredecessorSuccessorCalculate();
            PressEnterToExit();
        }

        public static void PredecessorSuccessorCalculate()
        {

            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int predecessor = num - 1;
            int successor = num + 1;

            Console.WriteLine($"The predecessor of {num} is {predecessor}");
            Console.WriteLine($"The succesor of {num} is {successor}");

        }


         public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    }
}