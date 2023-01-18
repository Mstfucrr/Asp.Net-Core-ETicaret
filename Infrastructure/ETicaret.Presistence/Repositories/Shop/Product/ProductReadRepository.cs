using ETicaret.Application.Repositories.Shop;
using ETicaret.Domain.Entities;
using ETicaret.Presistence.Contexts;

namespace ETicaret.Presistence.Repositories.Shop;

public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
{
    public ProductReadRepository(ETicaretDbContext context) : base(context)
    {
    }
}