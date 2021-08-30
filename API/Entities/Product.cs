using System;
using System.Collections.Generic;

#nullable disable

namespace API.Entities
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
