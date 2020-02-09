using QuickBuy.Domain.ValuableObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public class Request : Entity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }

        public int FormOfPaymentId { get; set; }
        public FormOfPayment FormOfPayment { get; set; }

        public string CEP { get; set; }
        public string Estate { get; set; }
        public string City { get; set; }
        public string FullAddress { get; set; }
        public int NumAddress { get; set; }

        /// <summary>
        /// Request must have at least one item or many itens
        /// </summary>
        public ICollection<OrderItems> OrderItems { get; set; }

        public override void Validate()
        {
            ClearValidationMessages();

            if (this.OrderItems.Any())
                AddCritical("Order can't be without order item.");

            if (string.IsNullOrEmpty(this.CEP))
                AddCritical("CEP must be filled.");
        }
    }
}
