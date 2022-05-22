using Firma.Entities;
using Firma.Entities.Enums;

namespace Firma.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        List<HourContract> contracts { get; set; }

        public Worker(string name, WorkerLevel level, double salary)
        {
            Name = name;
            Level = level;
            BaseSalary = salary;
            contracts = new List<HourContract>();
        }
        public void AddContract(HourContract contract)
        {
            contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double total = 0;
            foreach (HourContract i in contracts)
            {
                if(i.Date.Month == month && i.Date.Year == year)
                {
                    total+=i.TotalValue();
                }
            }
            return total+BaseSalary;
        }
    }
}
