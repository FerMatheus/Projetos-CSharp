using System;

namespace ExercicioInterface.Entities
{
    public class Installment
    {
        public DateOnly DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateOnly date, double amount)
        {
            DueDate = date;
            Amount = amount;
        }
        public override string ToString()
        {
            return $"{DueDate} - {Amount}";
        }
    }
}