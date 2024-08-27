/* 
40) Create an application that displays the following sequence 
on the screen:
0 3 6 9 12 15 18 Finished!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Count0to18
{
    public class Count0to18
    {
        static void Main(string[] args)
        {
            Count();
            PressEnterToExit();
        }

        public static void Count()
        {
            int counter = 0;

            while (counter <= 18)
            {
                Console.WriteLine(counter);
                counter+=3;
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