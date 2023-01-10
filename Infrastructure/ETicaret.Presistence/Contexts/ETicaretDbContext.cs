using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace ETicaret.Presistence.Contexts
{
    public class ETicaretDbContext : DbContext
    {
        public ETicaretDbContext(DbContextOptions<ETicaretDbContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Comment> Comments { get; set; }

        

    }
}
