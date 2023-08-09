using AlphaHotel_API.Domain.Common;

namespace AlphaHotel_API.Repository.Interfaces
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        bool Remove(T entity);
        bool RemoveRange(List<T> entities);
        Task<bool> RemoveAsync(string id);
        Task<bool> Update(T entity);
        Task SoftDeleteAsync(string id);
        Task<int> SaveAsync();
    }
}
