using System;

namespace ConsoleApp2 {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rollno: ");
            int rno = int.TryParse(Console.ReadLine(), out var _rno) ? _rno : 0;

            Console.WriteLine("Enter Name: ");
            string sname = Console.ReadLine() ?? "Unknown";
            Console.WriteLine("Enter marks of 3 subjects (0-100): ");
            int m1 = ReadMark("Subject 1: ");
            int m2 = ReadMark("Subject 2: ");
            int m3 = ReadMark("Subject 3: ");

            int tot = m1 + m2 + m3;
            double per = (double)tot / 3.0;
            Console.WriteLine($"Total: {tot} , Percentage: {per:F2}%");
            if (per > 60)
            
                Console.WriteLine("First Class");
            
            else if (per > 50)
            
                Console.WriteLine("Second Class");
            
            else if (per > 35)
            
                Console.WriteLine("Pass");
            
            else
            
                Console.WriteLine("Fail");
        }
        static int ReadMark(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int mark) && mark >= 0 && mark <= 100)
                    return mark;
                Console.WriteLine("Invalid mark . Enter 0-100.");
            }
        }  





    }
}