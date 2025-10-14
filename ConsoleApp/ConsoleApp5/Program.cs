using System;

namespace ConsoleApp5
{
    internal class Program
    {
        class Utils
        {
            public static int Add(int a, int b) => a + b;
            public static int Diff(int a, int b) => a - b;
        
        }
        static void SwapByValue(int a, int b)
        {
            int temp = a;
            a = b; 
            b = temp;
            Console.WriteLine($"\ta = {a} , b = {b}");
        }
        static void SwapByRef(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
            Console.WriteLine($"\ta = {a} , b = {b}");

        }
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;

            Console.WriteLine("\nSwap by ref Example Working \n");
            Console.WriteLine($"\tBefore: a = {a} , b = {b} sum: {Utils.Add(a, b)} , Diff: {Utils.Diff(a, b)}");
            SwapByRef(ref a, ref b);//swap sucessful since swapbyref doesnt need to return anything it just swaps the address 
            Console.WriteLine($"\tAfter: a = {a} , b = {b} sum: {Utils.Add(a, b)} , Diff: {Utils.Diff(a, b)}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("\nSwap by Value Example NOT Working since the method doesnt return the values \n");
            Console.WriteLine($"\tBefore: a = {a} , b = {b} sum: {Utils.Add(a, b)} , Diff: {Utils.Diff(a, b)}");
            SwapByValue(a, b);// doesnt work since swapbyvalue doesnt return anything 
            Console.WriteLine($"\tAfter: a = {a} , b = {b} sum: {Utils.Add(a, b)} , Diff: {Utils.Diff(a, b)}");
            Console.ReadKey();

        }
    }
}