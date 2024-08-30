/* 
  13) Create an algorithm that reads an employee's salary, 
 calculates, and shows their new salary with a 15% increase.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.SalaryRaise
{
    public class SalaryRaise
    {
        static void Main(string[] args)
        {
            Algorithm();
            PressEnterToExit();
        }

        public static void Algorithm()
        {
            Console.WriteLine("What is the value of your salary ?");
            double salary = double.Parse(Console.ReadLine());

            double salaryRaise = salary * 0.15;

            Console.WriteLine($"Your new salary with a raise of 15% is: {salary + salaryRaise}");
        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}