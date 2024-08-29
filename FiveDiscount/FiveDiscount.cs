/* 
 12) Create a program that reads the price of a product, 
 calculates, and shows its PROMOTIONAL PRICE with a 5% discount.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.FiveDiscount
{
    public class FiveDiscount
    {
        static void Main(string[] args)
        {
            Algorithm();
            PressEnterToExit();
        }

        public static void Algorithm()
        {

            Console.WriteLine("How much does the product costs ?");
            double productPrice = double.Parse(Console.ReadLine());

            double discount = productPrice * 0.05;

            Console.WriteLine($"The original price of the product is: {productPrice} USD");
            Console.WriteLine($"The price with discount is :  {productPrice - discount} USD");

        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}