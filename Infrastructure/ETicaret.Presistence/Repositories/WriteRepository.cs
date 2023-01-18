using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities.Common;
using ETicaret.Presistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Presistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T: BaseEntity
    {
        private readonly ETicaretDbContext _context;

        public WriteRepository(ETicaretDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            var entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> entities)
        {
            await Table.AddRangeAsync(entities);
            return true;
        }

        public Task<bool> UpdateAsync(T entity)
        {
            Table.Update(entity);
            return Task.FromResult(_context.SaveChanges() > 0);
        }

        public bool DeleteRange(List<T> entities)
        {
            Table.RemoveRange(entities);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(T entity)
        {
            var entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted; 
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var entity = await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
            return Delete(entity);
        }

        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();

    }
}
