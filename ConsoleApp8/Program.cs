using System;
namespace Program
{
    class PasswordLengthExeception : Exception
    {
        public PasswordLengthExeception() : base("Password Length must be greater than or equal to 6"){ }
    }
    class SpecialCharException : Exception
    {
        public SpecialCharException(): base("Password must contain at least one special character"){ }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();

                if (password.Length < 6)

                    throw new PasswordLengthExeception();

                if (!(password.Contains("!") || password.Contains("@") ||
                    password.Contains("#") || password.Contains("$") ||
                    password.Contains("%") || password.Contains("^") ||
                    password.Contains("&") || password.Contains("*") ||
                    password.Contains("(") || password.Contains(")")))
                    throw new SpecialCharException();
                Console.WriteLine("Valid Password");
            }
            catch (PasswordLengthExeception e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SpecialCharException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}