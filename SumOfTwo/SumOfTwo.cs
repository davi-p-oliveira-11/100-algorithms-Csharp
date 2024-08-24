/* 
4) Develop an algorithm that reads two integers and displays the sum between them.
Example:
Enter a value: 8
Enter another value: 5
The sum of 8 and 5 is equal to 13.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.SumOfTwo
{
    public class SumOfTwo
    {
         static void Main(string[] args)
        {
            Sum();
            PressEnterToExit();
        }

        public static void Sum() 
        {
           Console.WriteLine("Enter the first number: \r");
           int num1 = int.Parse(Console.ReadLine());

           Console.WriteLine("Enter the second number: \r");
           int num2 = int.Parse(Console.ReadLine());

           int sum = num1 + num2;

           Console.WriteLine("The sum between " + num1 + " and " + num2 + " is " + sum);
        }


        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

}
