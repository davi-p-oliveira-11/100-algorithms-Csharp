/* 
 10) Write an algorithm that reads the width and height of a wall, 
 calculates and displays the area to be painted, and the amount of paint needed for the job, 
 knowing that each liter of paint covers an area of 2 square meters.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.PaintNeeded
{
    public class PaintNeeded
    {
        static void Main(string[] args)
        {
            Calculate();
            PressEnterToExit();
        }

        public static void Calculate()
        {
            Console.WriteLine("Type the height of the wall in meters:");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Type the width of the wall in meters:");
            double width = double.Parse(Console.ReadLine());

            double area = width * height;
            double paintNeeded = area * 0.5;

            Console.WriteLine($"The area of the wall to be painted is equivalent to {area} m²");
            Console.WriteLine($"and the amount of paint needed is equivalent to {paintNeeded} liters.");
        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}