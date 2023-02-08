using System;
using System.Collections.Generic;

namespace TechieTrading.Shared.Domain
{
    public class TradeOrderItem : BaseDomainModel
    {
        public int Quantity { get; set; }
        public int TradeOrderId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
