using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        //# CONCEPT OF ENUM
//      You cannot declare types (like enum, class, interface, struct, delegate) inside a method body —       including Main() or any other method.
        enum Month { Jan = 1, Feb, March, April, May, June }
        static void Main(string[] args)
        {
            //#ENUM
            Console.WriteLine("Enum Month: "+Month.March);
            Console.WriteLine("Enum Month number: "+(int)Month.March);
            //#BOXING & UNBOXING
            int a = 3;
            object b = a; //boxing 
            int c = (int)b; //unboxing 
            // int d = b;
            Console.WriteLine($"c = {c}  , b = {b}");

            //#ARRAY() {fixed in side} AND LIST<T> {resizable}

            //# this is a list and can be resized as per our liking ;

            var list = new List<int> { 10, 20, 30 };
            //# can use fn like list.Add(20)
            list.Add(20);
            //# these are a few ways to anounce the array but they have fixed length
            //# Method 1 no inialization more used and more practial
            int[] list2 = new int[3];
            list2[0] = 30;
            list2[1] = 10;
            list2[2] = 70;

            //# Method 2 with [][square brackets] this is more mordern compared to list4 
            int[] list3 = [10, 20, 30];
            //# Method 2 with {}{square brackets} this is older and traditnal compared to list3 
            int[] list4 = { 10, 20, 30 };
            Console.WriteLine("----------------------- List1 ----------------------------");
            foreach (var x in list) Console.WriteLine(x);
            Console.WriteLine("----------------------- List2 ----------------------------");
            foreach (var x in list2) Console.WriteLine(x);
            Console.WriteLine("----------------------- List3 ----------------------------");
            foreach (var x in list3) Console.WriteLine(x);
            Console.WriteLine("----------------------- List4 ----------------------------");
            foreach (var x in list4) Console.WriteLine(x);
            









        }
    }
}