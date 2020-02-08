using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class OrderItems : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public override void Validate()
        {
            ClearValidationMessages();

            if (this.ProductId == 0)
                AddCritical("The product reference was not identified.");

            if (this.Quantity == 0)
                AddCritical("Quantity not informing.");
        }
    }
}
