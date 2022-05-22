namespace OrderSystem.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Item { get; set; }

        public OrderItem()
        {
        }
        public OrderItem(int quantity, Product item)
        {
            Quantity = quantity;
            Price = item.Price;
            Item = item;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}