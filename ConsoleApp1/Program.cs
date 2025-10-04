<<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information
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
=======
﻿using System;

class Example {
    static void CheckAge(int age) {
        if (age < 18) {
            throw new ArgumentException("Not eligible to vote");
        }
        Console.WriteLine("Eligible to vote");
    }

    static void Main() {
        try {
            CheckAge(19);
        } catch (ArgumentException e) {
            Console.WriteLine("Error: " + e.Message);
        } finally {
            Console.WriteLine("Check completed");
        }
    }
}
>>>>>>> 3447f8a (merging lenovo)
