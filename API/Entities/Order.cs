using System;
using System.Collections.Generic;

#nullable disable

namespace API.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int OrderId { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
