using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entity
    {
        private List<string> _validationMessages { get; set; }
        private List<string> ValidationMessages
        {
            get { return _validationMessages ?? (_validationMessages = new List<string>()); }
        }
        protected void ClearValidationMessages()
        {
            ValidationMessages.Clear();
        }
        protected void AddCritical(string critical)
        {
            ValidationMessages.Add("Critical: " + critical);
        }

        public abstract void Validate();
        protected bool IsValid
        {
            get { return !(ValidationMessages.Any()); }
        }
    }
}
