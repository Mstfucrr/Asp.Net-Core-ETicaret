namespace ETicaret.Domain.Entities
{
    public class Seller : AppUser
    {
        public virtual ICollection<Product>? Products { get; set; }
    }
}
