using Microsoft.EntityFrameworkCore;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.ValuableObject;
using QuickBuy.Repository.Config;

namespace QuickBuy.Repository.Context
{
    public class QuickBuyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<FormOfPayment> FormsOfPayment { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// Mapping classes here...
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemsConfiguration());
            modelBuilder.ApplyConfiguration(new RequestConfiguration());
            modelBuilder.ApplyConfiguration(new FormOfPaymentConfiguration());

            /// Initial load into FormOfPayment table
            modelBuilder
                .Entity<FormOfPayment>()
                .HasData(
                    new FormOfPayment { Id = 1, Name = "Bill", Desc = "Form of Payment - Bill" },
                    new FormOfPayment { Id = 2, Name = "CreditCard", Desc = "Form of Payment - Credit Card" },
                    new FormOfPayment { Id = 3, Name = "Deposity", Desc = "Form of Payment - Deposity" });

            base.OnModelCreating(modelBuilder);
        }
    }
}
