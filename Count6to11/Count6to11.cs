/* 
38) Write a program that displays the following sequence on the screen:
6 7 8 9 10 11 It's over !
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.Count6to11
{
    public class Count6to11
    {
        static void Main(string[] args)
        {
            Count();
            PressEnterToExit();
        }

        public static void Count()
        {

            int counter = 6;

            while (counter <= 11)
            {
                Console.WriteLine(counter);
                counter++;

            }
            Console.WriteLine("It's over !");
        }


        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }



    }
}