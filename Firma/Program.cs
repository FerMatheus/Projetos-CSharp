using Firma.Entities;
using Firma.Entities.Enums;


namespace Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string name = Console.ReadLine();
            Department flow = new(name);
            Console.Clear();

            Console.WriteLine($"\tDepartment {flow.Name}\n");
            Console.WriteLine("Enter worker data:");
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("Level:");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salary:");
            double salary = double.Parse(Console.ReadLine());
            Worker worker = new(name, level, salary);

            Console.WriteLine("How many contracts to this worker?");
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter #{i} contract data:");
                Console.Write("Date (YYYY/MM/DD): ");
                DateOnly data = DateOnly.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hour = int.Parse(Console.ReadLine());
                HourContract x = new (data, value, hour);
                Console.WriteLine(x.Date);
                worker.AddContract(x);
            }
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY :)");
            string[] date = Console.ReadLine().Split("/");
            int month = int.Parse(date[0]);
            int year = int.Parse(date[1]);

            Console.Write($"Name: {worker.Name}\n");
            Console.Write($"Department: {flow.Name}\n");
            Console.Write($"Income: for {month}/{year}: {worker.Income(year,month)}\n");

        }
    }
}
