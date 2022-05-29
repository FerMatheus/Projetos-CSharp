using System;
using ExercicioInterface.Entities;
using ExercicioInterface.Services;

namespace ExercicioInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter contract data\nNumber: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.Write("Date (dd/MM/yyyy): ");
            DateOnly date = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy");
            System.Console.WriteLine("Contract value: ");
            double amount = double.Parse(Console.ReadLine());

            Contract contract = new(number, date, amount);

            System.Console.WriteLine("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            OnlineContract payments = new(new Paypal());

            payments.AddPayments(contract, installments);

            foreach (var i in contract.Installments)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}