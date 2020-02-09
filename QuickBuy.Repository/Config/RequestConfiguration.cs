using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;

namespace QuickBuy.Repository.Config
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasKey(r => r.Id);

            builder
                .Property(r => r.Date)
                .IsRequired();

            builder
                .Property(r => r.ExpectedDeliveryDate)
                .IsRequired();

            builder
                .Property(r => r.CEP)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(r => r.City)
                .HasMaxLength(100);

            builder
                .Property(r => r.Estate)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(r => r.FullAddress)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.NumAddress)
                .IsRequired();
        }
    }
}
