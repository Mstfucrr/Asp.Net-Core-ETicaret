using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? Birthdate { get; set; }
        public ICollection<ShippingAddress>? Addresses { get; set; } 
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
