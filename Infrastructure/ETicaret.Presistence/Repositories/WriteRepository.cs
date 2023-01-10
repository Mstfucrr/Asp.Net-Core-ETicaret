using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities.Common;
using ETicaret.Presistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Presistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T: BaseEntity
    {
        private readonly ETicaretDbContext _context;
        public DbSet<T> Table { get; }

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

        public bool Delete(T entity)
        {
            var entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted; 
        }

        public bool Delete(string id)
        {
            var entityEntry = Table.Remove(Table.FirstOrDefault(x => x.Id == Guid.Parse(id)));
            return entityEntry.State == EntityState.Deleted;
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
