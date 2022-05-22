using OrderSystem.Entities.Enums;

namespace OrderSystem.Entities
{
    class Order
    {
        public Client Client { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; }

        public Order()
        {
        }
        public Order(OrderStatus status)
        {
            Status = status;
            Date = DateTime.Now;
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
    }
}
