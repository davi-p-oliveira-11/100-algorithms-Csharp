/* 
 43) Develop an algorithm that displays a countdown from 30 to 1, marking the numbers 
 that are divisible by 4, exactly as shown below:
30 29 [28] 27 26 25 [24] 23 22 21 [20] 19 18 17 [16]...
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.Count31to0
{
    public class Count31to0
    {
        static void Main(string[] args)
        {
            Count();
            PressEnterToExit();
        }

        public static void Count()
        {
            int counter = 31;

            while (counter >= 2)
            {         
                counter--;
                if (counter % 4 == 0)
                {
                    Console.WriteLine($"[{counter}]");
                } 
                else
                {
                    Console.WriteLine($"{counter}");
                }
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