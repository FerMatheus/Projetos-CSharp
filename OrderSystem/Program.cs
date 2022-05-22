using OrderSystem.Entities;
using OrderSystem.Entities.Enums;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
            Client client = new(name, birthDate,email);
            Console.WriteLine();
            Console.WriteLine("Enter order date:");
            Console.Write("Status: ");
            OrderStatus status = OrderStatus.Parse<OrderStatus>(Console.ReadLine());
            Order order = new(status, client);
            Console.Write("How many items to this order? ");
            int qtde = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtde; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Produtc name: ");
                name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product x = new Product(name, price);
                OrderItem y = new OrderItem(quantity, x);
                order.AddItem(y);
            }
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
