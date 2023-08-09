using AlphaHotel_API.Domain.Common;
using System.Linq.Expressions;

namespace AlphaHotel_API.Repository.Interfaces
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);    
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetByIdAsyncRepo(string id, bool tracking = true);
    }
}
