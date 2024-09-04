using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.KnowYourSalary
{
    public class KnowYourSalary
    {
        static void Main(string[] args)
        {
            Algorithm();
            PressEnterToExit();
        }

        public static void Algorithm()
        {
            Console.WriteLine("How many days did you work last month ?");
            int daysWorked = int.Parse(Console.ReadLine());

            int salary = daysWorked * 200;

            Console.WriteLine($"The employee worked for {daysWorked} days");
            Console.WriteLine($"and will receive {salary} USD");
        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}