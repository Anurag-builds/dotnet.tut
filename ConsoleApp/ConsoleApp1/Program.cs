// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number: ");
            //Phrase to prevent exceptions bad Input 
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid number entered - using 0.");
                a = 0;
            }

            Console.WriteLine("Enter Second Number: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Invalid number entered - using 0.");
                b = 0;
            }

            int c = a + b;
            //string interpolation (clean and morder)

            Console.WriteLine($"Addition of {a} and {b} is equal to {c}");
            Console.WriteLine("Press any key to exit ");
            Console.ReadKey();

        }
    }
}
