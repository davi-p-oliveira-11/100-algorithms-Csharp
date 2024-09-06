/* 
 18) Write a program that reads a person's year of birth, 
calculates their age, and then shows whether they are eligible to vote or not.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.CanYouVote
{
    public class CanYouVote
    {
         static void Main(string[] args)
        {
            Algorithm();
            PressEnterToExit();
        }

        public static void Algorithm()
        {
            
            Console.WriteLine("What is your year of birth ?");
            int yearOfBirth = int.Parse(Console.ReadLine());

            int currentYear = DateTime.Now.Year;
            int userAge = currentYear - yearOfBirth;

            if (userAge >= 16)
            {
                Console.WriteLine("You are already eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are already eligible to vote.");
            }

        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}