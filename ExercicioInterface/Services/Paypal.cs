using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioInterface.Services
{
    public class Paypal : IPayment
    {
        public double Tax(double amount, int month)
        {
            double MonthTax = amount * 0.01 * month;
            double PaymentTax = (amount + MonthTax) * 0.02;
            return amount + MonthTax + PaymentTax;
        }
    }
}