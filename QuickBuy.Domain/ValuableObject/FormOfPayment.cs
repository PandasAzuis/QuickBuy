﻿using QuickBuy.Domain.Entities;
using QuickBuy.Domain.Enumerated;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.ValuableObject
{
    public class FormOfPayment : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public bool IsUndefined
        {
            get { return Id == (int)TypeFormOfPaymentEnum.Undefined; }
        }
        public bool IsBill
        {
            get { return Id == (int)TypeFormOfPaymentEnum.Bill; }
        }
        public bool IsCreditCard
        {
            get { return Id == (int)TypeFormOfPaymentEnum.CreditCard; }
        }
        public bool IsDeposity
        {
            get { return Id == (int)TypeFormOfPaymentEnum.Deposity; }
        }

        public override void Validate()
        {
            ClearValidationMessages();

            if (Enum.IsDefined(typeof(TypeFormOfPaymentEnum), Id))
                AddCritical("Form of payment not registred.");

        }
    }
}
