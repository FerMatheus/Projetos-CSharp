using System;
using ExercicioInterface.Services;

namespace ExercicioInterface.Entities
{
    public class Contract
    {
        public int Number { get; set; }
        public DateOnly Date { get; set; }
        public double TotalValue { get; private set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateOnly date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }
        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}