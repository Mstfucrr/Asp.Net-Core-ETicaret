using ETicaret.Application.Repositories.Shop;
using ETicaret.Domain.Entities;
using ETicaret.Presistence.Contexts;

namespace ETicaret.Presistence.Repositories.Shop;

public class OrderWriteRepository : WriteRepository<Order> , IOrderWriteRepository
{
    public OrderWriteRepository(ETicaretDbContext context) : base(context)
    {
    }
}