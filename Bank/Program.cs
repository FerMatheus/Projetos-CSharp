using Bank.Entities;
using Bank.Entities.Exception;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Numer: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine());

                Account x = new(number, name, balance, limit);
                Console.Write("\nEnter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                x.Withdraw(amount);
                Console.WriteLine($"New balance: {x.Balance.ToString("F2")}");
            }
            catch (DomainException ex)
            {
                Console.WriteLine($"Withdraw error: {ex.Message}");
            }
        }
    }
}
