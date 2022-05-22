using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem()
        {
        }
        public OrderItem(int quantity, Product item)
        {
            Quantity = quantity;
            Price = item.Price;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}