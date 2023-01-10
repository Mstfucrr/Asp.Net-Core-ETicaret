using ETicaret.Domain.Entities.Common;

namespace ETicaret.Application.Repositories
{
    public interface IWriteRepository<T> :IRepository<T> where T: BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        Task<bool> UpdateAsync(T entity);
        bool Delete(T entity);
        bool Delete(string id);
        Task<int> SaveAsync();
    }
}
