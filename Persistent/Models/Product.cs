using System;
using System.Collections.Generic;

namespace Persistent.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Make { get; set; } = null!;
        public int Price { get; set; }
        public int Category { get; set; }
    }
}
