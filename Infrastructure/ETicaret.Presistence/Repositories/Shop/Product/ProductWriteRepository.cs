using ETicaret.Application.Repositories.Shop;
using ETicaret.Domain.Entities;
using ETicaret.Presistence.Contexts;

namespace ETicaret.Presistence.Repositories.Shop;

public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
{
    public ProductWriteRepository(ETicaretDbContext context) : base(context)
    {
    }
}