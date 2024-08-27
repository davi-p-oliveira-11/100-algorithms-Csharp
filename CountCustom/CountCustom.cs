/* 
 42) Create an algorithm that asks the user for any positive integer and displays a countdown up to that value:
Ex: Enter a value: 35
Count: 1 2 3 4 5 6 7 ... 33 34 35 Finished!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.CountCustom
{
    public class CountCustom
    {
        static void Main(string[] args)
        {
            Count();
            PressEnterToExit();
        }

        public static void Count()
        {
            Console. WriteLine("Enter a value: ");
            int userNumber = int.Parse(Console.ReadLine());

            int counter = 1;

            while (counter <= userNumber)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.WriteLine("it's over !");
        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}