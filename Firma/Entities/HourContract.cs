namespace Firma.Entities
{
    class HourContract
    {
        public DateOnly Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract(DateOnly date, double value, int hours)
        {
            Date = date;
            ValuePerHour = value;
            Hours = hours;
        }
        public double TotalValue()
        {
            return ValuePerHour*Hours;
        }
    }
}
