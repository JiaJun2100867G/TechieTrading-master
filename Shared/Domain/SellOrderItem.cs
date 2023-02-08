using System;
using System.Collections.Generic;

namespace TechieTrading.Shared.Domain
{
    public class SellOrderItem : BaseDomainModel
    {
        public int Quantity { get; set; }
        public int SellOrderId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
