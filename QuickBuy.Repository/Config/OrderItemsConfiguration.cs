using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;

namespace QuickBuy.Repository.Config
{
    public class OrderItemsConfiguration : IEntityTypeConfiguration<OrderItems>
    {
        public void Configure(EntityTypeBuilder<OrderItems> builder)
        {
            builder.HasKey(o => o.Id);

            builder
                .Property(o => o.ProductId)
                .IsRequired();

            builder
                .Property(o => o.Quantity)
                .IsRequired();
        }
    }
}
