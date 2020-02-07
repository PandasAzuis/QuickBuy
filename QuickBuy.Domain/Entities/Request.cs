using QuickBuy.Domain.ValuableObject;
using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class Request
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
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
        public ICollection<ItemRequest> ItemRequests { get; set; }
    }
}
