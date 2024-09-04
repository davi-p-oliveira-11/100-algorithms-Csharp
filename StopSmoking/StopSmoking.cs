using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.StopSmoking
{
    public class StopSmoking
    {
        static void Main(string[] args)
        {
            Algorithm();
            PressEnterToExit();
        }

        public static void Algorithm()
        {
            Console.WriteLine("How many cigarretes do you smoke per day ?");
            int cigarretesPerDay = int.Parse(Console.ReadLine());

            Console.WriteLine("How many years have you been smoking ?");
            int yearsSmoking = int.Parse(Console.ReadLine());

            int totalCigarsSmoked = cigarretesPerDay * 365 * yearsSmoking;

            int minutesLost = totalCigarsSmoked * 10;

            int daysLost = minutesLost / 1440;

            Console.WriteLine($"You have already lost {daysLost} days of your life.");
        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
 }
