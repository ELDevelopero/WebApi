using System;
using System.Collections.Generic;

namespace EntityFW.Models
{
    public partial class Products
    {
        public Products()
        {
            Ratings = new HashSet<Ratings>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public virtual ICollection<Ratings> Ratings { get; set; }
    }
}
