/* 
7) Create an algorithm that reads a real number and displays its double and its one-third.

Example:
Enter a number: 3.5
The double of 3.5 is 7.0
One-third of 3.5 is 1.16666
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.DoubleThird
{
    public class DoubleThird
    {
        
        static void Main(string[] args)
        {
            Calculate();
            PressEnterToExit();
        }


        public static void Calculate()
        {
           
            Console.WriteLine("Type a number: ");
            double num = double.Parse(Console.ReadLine());

            double twice = num * 2;
            double thirdPart = num / 3;

            Console.WriteLine($"The double of {num} is {twice}");
            Console.WriteLine($"The third part of {num} is {thirdPart}");

        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
    }
}