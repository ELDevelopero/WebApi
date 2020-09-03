using System;
using System.Collections.Generic;

namespace EntityFW.Models
{
    public partial class BasketItems
    {
        public string Id { get; set; }
        public string BasketId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public virtual Baskets Basket { get; set; }
    }
}
