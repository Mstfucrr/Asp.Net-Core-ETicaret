using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    public class Order : BaseEntity
    {
        
        public string? OrderNumber { get; set; }
        public Guid? CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public virtual ICollection<OrderDetail>? OrderItems { get; set; }
        public decimal TotalPrice { get; set; }
        public string? Description { get; set; }

    }
}
