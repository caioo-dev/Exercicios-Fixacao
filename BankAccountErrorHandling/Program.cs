using BankAccountErrorHandling.Entities;
using BankAccountErrorHandling.Entities.Exceptions;
using System.Security.Principal;

namespace BankAccountErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");

            Console.Write("Number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string accountHolder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine());

            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(accountNumber, accountHolder, initialBalance, withdrawLimit);

            Console.Write("Enter amount for withdraw: ");
            double withdrawAmount = double.Parse(Console.ReadLine());
            try
            {
                account.Withdraw(withdrawAmount);
                Console.WriteLine("New balance: " + account.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
