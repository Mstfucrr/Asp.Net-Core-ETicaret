using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    public class OrderDetail : BaseEntity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Order Order { get; set; }

        public OrderDetail()
        {
            this.Price = Product!.Price * Quantity;
        }
    }
}
