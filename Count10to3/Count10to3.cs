/* 
39) Write an algorithm that displays the following sequence on the screen:
10 9 8 7 6 5 4 3 It's over!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.Count10to3
{
    public class Count10to3
    {
        static void Main(string[] args)
        {
            Count();
            PressEnterToExit();
        }

        public static void Count()
        {
            int counter = 10;

            while (counter >= 3)
            {
                Console.WriteLine(counter);
                counter--;
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