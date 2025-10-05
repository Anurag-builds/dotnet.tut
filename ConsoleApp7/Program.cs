using System;

namespace ConsoleApp7
{
    class InsufficientFundException(string message) : Exception(message)
    {
    }
    class BankAccount
    {
        public double Balance { get; set; } = 1000;
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new InsufficientFundException("Not enough Balance");

            }
            Balance -= amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new();
            try
            {
                account.Withdraw(3000);
                Console.WriteLine("withdraw Complete");
            }
            catch (InsufficientFundException e)
            {
                Console.WriteLine("Transaction Failed " + e.Message);
            }

        }
    }



}