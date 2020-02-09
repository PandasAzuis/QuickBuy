using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.ValuableObject;

namespace QuickBuy.Repository.Config
{
    public class FormOfPaymentConfiguration : IEntityTypeConfiguration<FormOfPayment>
    {
        public void Configure(EntityTypeBuilder<FormOfPayment> builder)
        {
            builder.HasKey(f => f.Id);

            builder
                .Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(f => f.Desc)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
