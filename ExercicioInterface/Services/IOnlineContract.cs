using System;
using ExercicioInterface.Entities;

namespace ExercicioInterface.Services
{
    public class OnlineContract
    {
        private IPayment _onlinePayment { get; set; }

        public OnlineContract(IPayment onlinePayment)
        {
            _onlinePayment = onlinePayment;
        }

        public void AddPayments(Contract contract, int month)
        {
            double basePayment = contract.TotalValue / month;
            for (int i = 1; i <= month; i++)
            {
                DateOnly date = contract.Date.AddMonths(i);
                double FullPayment = _onlinePayment.Tax(basePayment, i);
                contract.AddInstallment(new Installment(date, FullPayment));
            }
        }

    }
}