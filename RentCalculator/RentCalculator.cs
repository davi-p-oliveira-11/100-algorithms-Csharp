/* 
  14) The car rental company needs your help to charge for their services. 
 Write a program that asks for the number of kilometers driven by a 
 rented car and the number of days it was rented. Calculate the total price to pay, 
 knowing that the car costs $90 per day and $0.20 per kilometer driven.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCalculator
{
    public class RentCalculator
    {
        static void Main(string[] args)
        {
            Algorithm();
            PressEnterToExit();
        }

        public static void Algorithm()
        {
            Console.WriteLine("How many kilometers were driven with the rented car ?");
            double distanceTraveled = double.Parse(Console.ReadLine());

            Console.WriteLine("For how many days was the car rented ? ");
            double daysRented = double.Parse(Console.ReadLine());

            double costForDays = daysRented * 90;
            double costForDistance = distanceTraveled * 0.2;

            double totalCost = costForDays + costForDistance;

            Console.WriteLine($"The customer drove {distanceTraveled} km with the car");
            Console.WriteLine($"rented the car for {daysRented} days");
            Console.WriteLine($"which cost ${costForDays} dollars for the rental days ");
            Console.WriteLine($"and ${costForDistance} dollars for the kilometers driven,");
            Console.WriteLine($" the total cost the customer must pay is: ${totalCost} dollars");
        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}