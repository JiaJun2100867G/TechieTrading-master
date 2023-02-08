using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TechieTrading.Shared.Domain
{
    public class TradeOrder : BaseDomainModel
    {
        [Required]
        public DateTime? OrderDate { get; set; }
        [RegularExpression(@"(2[0-3]|[01]?[0-9]):([0-5]?[0-9]):([0-5]?[0-9])", ErrorMessage = "Time Format: HH:mm:ss")]
        public string OrderTime { get; set; }
        public string DeliveryType { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public List<TradeOrderItem> TradeOrderItem { get; set; }
    }
}
