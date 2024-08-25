/* 
Develop a program that reads a distance in meters and displays the equivalent values in other units.
Example:
Enter a distance in meters: 185.72
The distance of 185.72m corresponds to:
0.18572Km
1.8572Hm
18.572Dam
1857.2dm
18572.0cm
185720.0mm
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.MeasureConverter
{
    public class MeasureConverter
    {

         static void Main(string[] args)
        {
            Calculate();
            PressEnterToExit();
        }

        public static void Calculate()
        {
            
            Console.WriteLine("Type a distance in meters: ");
            double meters = double.Parse(Console.ReadLine());

            double kilometers = meters / 1000;
            double hectometers = meters / 100;
            double decameters = meters / 10;
            double decimeters = meters * 10;
            double centimeters = meters * 100;
            double milimeters = meters * 1000;

            Console.WriteLine($"The distance of {meters} corresponds to");
            Console.WriteLine($"{kilometers}km");
            Console.WriteLine($"{hectometers}hm");
            Console.WriteLine($"{decameters}dam");
            Console.WriteLine($"{decimeters}dm");
            Console.WriteLine($"{centimeters}cm");
            Console.WriteLine($"{milimeters}mm");
        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        
    }
}