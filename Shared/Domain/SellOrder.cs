using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TechieTrading.Shared.Domain
{
    public class SellOrder : BaseDomainModel
    {
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? OrderDate { get; set; }
        public int OrderTime { get; set; }
        public string DeliveryType { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public List<SellOrderItem> SellOrderItem { get; set; }
    }
}
