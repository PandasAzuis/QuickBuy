using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        /// <summary>
        /// A User can have none or many requests
        /// </summary>
        public ICollection<Request> Request { get; set; }
    }
}
