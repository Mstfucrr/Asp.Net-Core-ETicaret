using ETicaret.Application.Repositories.Shop;
using ETicaret.Domain.Entities;
using ETicaret.Presistence.Contexts;

namespace ETicaret.Presistence.Repositories.Shop;

public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
{
    public CategoryReadRepository(ETicaretDbContext context) : base(context)
    {
    }
}