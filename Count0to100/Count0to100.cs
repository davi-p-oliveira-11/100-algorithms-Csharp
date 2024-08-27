/* 
41) Develop a program that displays the following sequence on the screen:
100 95 90 85 80 ... 0 It's over!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.Counr0to100
{
    public class Count0to100
    {
        static void Main(string[] args)
        {
            Count();
            PressEnterToExit();
        }

        public static void Count()
        {
            int counter = 100;

            while (counter >= 0)
            {
                Console.WriteLine(counter);
                counter-=5;
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