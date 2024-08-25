/* 

9) Write an algorithm that reads how much money a person has in their wallet (in R$) 
and shows how many dollars they can buy. Consider US$1.00 = R$3.45.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.CurrencyConverter
{
    public class CurrencyConverter
    {
        static void Main(string[] args)
        {
            ConvertToBRL();
            PressEnterToExit();
        }

        public static void ConvertToBRL()
        {

        Console.WriteLine("How many BRL do you have in your pocket ?");
        double brl = double.Parse(Console.ReadLine());

        double dollarAmount = brl / 3.45;

        Console.WriteLine($"You can buy a total of {dollarAmount} USD");

        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}