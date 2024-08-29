/* 
 11) Develop a logic that reads the values of A, B, and C 
 of a quadratic equation and shows the value of Delta.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.DeltaCalculator
{
    public class DeltaCalculator
    {

        static void Main(string[] args)
        {
            Algorithm();
            PressEnterToExit();
        }

        public static void Algorithm()
        {

           Console.WriteLine("Enter the value of A: ");
           double valueOfA = double.Parse(Console.ReadLine());

           Console.WriteLine("Enter the value of B: ");
           double valueOfB = double.Parse(Console.ReadLine());

           Console.WriteLine("Enter the value of C: ");
           double valueOfC = double.Parse(Console.ReadLine());

           double delta = valueOfB * valueOfB - 4 * (valueOfA * valueOfC);

           Console.WriteLine($"The value of delta is equal to: {delta}");
           
        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
    }
}