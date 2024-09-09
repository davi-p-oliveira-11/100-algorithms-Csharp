/* 
20) Develop a program that reads an integer and shows whether it is EVEN or ODD."
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.EvenOrOdd
{
    public class EvenOrOdd
    {
        static void Main(string[] args)
        {
            Algorithm();
            PressEnterToExit();
        }

        public static void Algorithm()
        {
            Console.WriteLine("Type a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
              Console.WriteLine("Even number");
            }
            else
            {
              Console.WriteLine("Odd number");
            }
        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}