using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.SpeedMonitor
{
    public class SpeedMonitor
    {
        static void Main(string[] args)
        {
            Algorithm();
            PressEnterToExit();
        }

        public static void Algorithm()
        {
            Console.WriteLine("What is the speed reached by the car ?");
            int carSpeed = int.Parse(Console.ReadLine());

            int exceedingSpeed = carSpeed - 80;
            int fineValue = exceedingSpeed * 5;

            if (carSpeed > 80)
            {
              Console.WriteLine($"The car reached a speed of {carSpeed}km/h exceeding {exceedingSpeed} km/h of");
              Console.WriteLine($"the allowed speed. The driver will have to pay a fine of {fineValue} USD");
            }
            else
            {
              Console.WriteLine($"The driver did not exceed the speed limit, so they will not have to pay a fine.");
            }
        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}