using System.Linq.Expressions;
using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities.Common;
using ETicaret.Presistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Presistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ETicaretDbContext _context;
        public DbSet<T> Table => _context.Set<T>();
        public IQueryable<T> GetAll() 
            => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) 
            => Table.Where(method);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method) 
            => await Table.FirstOrDefaultAsync(method);

        public async Task<T> GetyIdAsync(string id)
            => await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));


    }
}
