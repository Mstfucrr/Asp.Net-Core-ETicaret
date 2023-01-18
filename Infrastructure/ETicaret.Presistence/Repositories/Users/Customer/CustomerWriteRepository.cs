using ETicaret.Application.Repositories.Users;
using ETicaret.Domain.Entities;
using ETicaret.Presistence.Contexts;

namespace ETicaret.Presistence.Repositories.Users;

public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
{
    public CustomerWriteRepository(ETicaretDbContext context) : base(context)
    {
    }
}