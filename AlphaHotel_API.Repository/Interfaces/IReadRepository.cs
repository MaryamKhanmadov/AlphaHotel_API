using AlphaHotel_API.Domain.Common;
using System.Linq.Expressions;

namespace AlphaHotel_API.Repository.Interfaces
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        List<T> GetWhere(Expression<Func<T, bool>> method);    
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(string id);
    }
}
