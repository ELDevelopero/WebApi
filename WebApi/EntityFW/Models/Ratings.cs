using System;
using System.Collections.Generic;

namespace EntityFW.Models
{
    public partial class Ratings
    {
        public string Id { get; set; }
        public int Rate { get; set; }
        public string ProductId { get; set; }
        public string Comment { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public virtual Products Product { get; set; }
    }
}
