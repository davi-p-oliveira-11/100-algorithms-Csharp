/* 
 3) Create a program that reads the name and salary of an employee, and displays a message at the end.

Example:
Employee Name: Jane Doe
Salary: 1850.45
The employee Jane Doe has a salary of R$1850.45 in June.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.HelloEmployee
{
    public class HelloEmployee
    {
         static void Main(string[] args)
        {
            SayHelloEmployee();
            PressEnterToExit();
        }

        public static void SayHelloEmployee() 
        {

           Console.WriteLine("What is the employee name ? \r");
           string name = Console.ReadLine();

           Console.WriteLine("Enter your salary: \r");
           string salary = Console.ReadLine();

           Console.WriteLine("What was the last month that you worked ? \r");
           string month = Console.ReadLine();

           Console.WriteLine("The employee " + name + " has a salary of " + salary + "USD in " + month);

        }
        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    
}