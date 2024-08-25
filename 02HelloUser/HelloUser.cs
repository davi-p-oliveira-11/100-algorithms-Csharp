using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_csharp.HelloUser
{
    public class HelloUser
    {
        static void Main(string[] args)
        {
            SayHelloToUser();
            PressEnterToExit();
        }

        public static void SayHelloToUser()
        {
           Console.WriteLine("What is your name? \r");
           string name = Console.ReadLine();

           Console.WriteLine("Hello, " + name + " nice to meet you !");
        }

        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

}