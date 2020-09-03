using System;
using System.Collections.Generic;

namespace EntityFW.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string OrderStatus { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
