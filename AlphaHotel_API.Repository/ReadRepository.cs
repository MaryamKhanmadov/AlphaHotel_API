using AlphaHotel_API.Domain.Common;
using AlphaHotel_API.Repository.Contexts;
using AlphaHotel_API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AlphaHotel_API.Repository
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public ReadRepository(AppDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task<List<T>> GetAll()
         =>  await Table.ToListAsync();

        public Task<T> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        {
            throw new NotImplementedException();
        }

        public List<T> GetWhere(Expression<Func<T, bool>> method)
        {
            throw new NotImplementedException();
        }
    }
}
