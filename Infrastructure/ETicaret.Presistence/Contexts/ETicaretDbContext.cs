using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace ETicaret.Presistence.Contexts
{
    public class ETicaretDbContext : DbContext
    {
        public ETicaretDbContext(DbContextOptions<ETicaretDbContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>(category =>
            {
                category.HasMany(c => c.ChildCategories)
                    .WithOne(c => c.ParentCategory)
                    .HasForeignKey(c => c.ParentCategoryId);
            });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Seller> Sellers { get; set; }



    }
}
