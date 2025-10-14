using System;

namespace ConsoleApp6
{
    internal class Program
    {
        //#Optional, Named, Params

        //optional
        static int Show(int a, int b = 150) => a + b;
        //Params Concept  
        static void PrintParams(params string[] items)
        {
            foreach (var x in items)
            {
                Console.Write($"{x} , ");
            }
        }
        
        static void Main(string[] args)
        {
            //named
            int foo = Show(a: 10);
            Console.WriteLine(foo);
            Console.WriteLine("------------------------------");

            PrintParams("10", "20", "30", "40");
        }
    }
}