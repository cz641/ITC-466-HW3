using System;
using System.Collections.Generic;

namespace HW3EX1B4.Model
{
    public class Cart
    {
        public decimal TotalAmount { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }

        public string CustomerEmail { get; set; }
    }

    public class OrderItem
    {
        public string Sku { get; set; }
        public int Quantity { get; set; }
    }
}