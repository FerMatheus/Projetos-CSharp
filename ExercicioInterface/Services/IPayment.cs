namespace ExercicioInterface.Services
{
    public interface IPayment
    {
        public double Tax(double amount, int month);
    }
}