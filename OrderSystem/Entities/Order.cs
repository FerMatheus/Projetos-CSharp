using OrderSystem.Entities.Enums;
using System.Text;

namespace OrderSystem.Entities
{
    class Order
    {
        public Client Client { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }
        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Date = DateTime.Now;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("ORDER SUMMARY");
            str.AppendLine($"Order moment: {Date.ToString("dd/MM/yyyy HH:mm:ss")}");
            str.AppendLine($"Client: {Client.Name} {Client.BirthDate} {Client.Email}");
            str.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                str.AppendLine($"{item.Item.Name}, ${item.Price.ToString("F2")}, Quantity: {item.Quantity}, SubTotal: ${item.SubTotal().ToString("F2")}");
            }
            str.AppendLine($"Total price: ${Total().ToString("F2")}");
            return str.ToString();
        }
    }
}
