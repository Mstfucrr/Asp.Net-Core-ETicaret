namespace ETicaret.Domain.Entities
{
    public class Customer : AppUser
    {
        public DateTime? Birthdate { get; set; }
        public ICollection<ShippingAddress>? Addresses { get; set; } 
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
