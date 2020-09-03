using System;
using System.Collections.Generic;

namespace EntityFW.Models
{
    public partial class ProductCategories
    {
        public string Id { get; set; }
        public string Category { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
