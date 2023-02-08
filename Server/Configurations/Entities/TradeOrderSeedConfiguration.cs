using System;
using Microsoft.EntityFrameworkCore;
using TechieTrading.Shared.Domain;

namespace TechieTrading.Server.Configurations.Entities
{
    public class TradeOrderSeedConfiguration : IEntityTypeConfiguration<TradeOrder>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TradeOrder> builder)
        {
            builder.HasData(
                new TradeOrder
                {
                    Id = 1,
                    OrderDate = DateTime.Today.Date,
                    OrderTime = DateTime.Now.ToString("HH:mm:ss"),
                    DeliveryType = "Store-Pick-Up",
                    StaffId = 1,
                    CustomerId = 1
                }
            );
        }
    }
}
