using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public decimal Price { get; set; }

        public override void Validate()
        {
            ClearValidationMessages();
        }
    }
}
