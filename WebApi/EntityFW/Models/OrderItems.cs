using System;
using System.Collections.Generic;

namespace EntityFW.Models
{
    public partial class OrderItems
    {
        public string Id { get; set; }
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public virtual Orders Order { get; set; }
    }
}
