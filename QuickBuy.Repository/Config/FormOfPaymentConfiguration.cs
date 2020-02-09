using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.ValuableObject;
using System;

namespace QuickBuy.Repository.Config
{
    public class FormOfPaymentConfiguration : IEntityTypeConfiguration<FormOfPayment>
    {
        public void Configure(EntityTypeBuilder<FormOfPayment> builder)
        {
            throw new NotImplementedException();
        }
    }
}
