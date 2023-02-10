﻿using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    public class OrderDetail : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Guid OrderId { get; set; }
        public Order? Order { get; set; }

    }
}
