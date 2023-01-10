using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    public class ShippingAddress : BaseEntity
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string? ZipCode { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Order? Order { get; set; }

    }
}
