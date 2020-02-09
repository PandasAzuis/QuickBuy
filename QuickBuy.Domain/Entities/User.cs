using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        /// <summary>
        /// A User can have none or many requests
        /// </summary>
        public virtual ICollection<Request> Request { get; set; }

        public override void Validate()
        {
            ClearValidationMessages();

            if (string.IsNullOrEmpty(this.Email))
                AddCritical("Email not informig.");

            if (string.IsNullOrEmpty(this.Password))
                AddCritical("Password not informig.");
        }
    }
}
