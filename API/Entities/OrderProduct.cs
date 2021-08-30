using System;
using System.Collections.Generic;

#nullable disable

namespace API.Entities
{
    public partial class OrderProduct
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int ProductId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
