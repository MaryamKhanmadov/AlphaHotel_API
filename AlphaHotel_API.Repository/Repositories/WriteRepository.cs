using AlphaHotel_API.Domain.Common;
using AlphaHotel_API.Repository.Contexts;
using AlphaHotel_API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AlphaHotel_API.Repository.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public WriteRepository(AppDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            await SaveAsync();
            return entityEntry.State == EntityState.Added;
        }

        public Task<bool> AddRangeAsync(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException();
            EntityEntry entityEntry = Table.Update(entity);
            await SaveAsync();
            return entityEntry.State == EntityState.Modified;
        }

        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            T model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
            return Remove(model);
        }

        public bool RemoveRange(List<T> entities)
        {
            Table.RemoveRange(entities); 
            return true;
        }

        public async Task<int> SaveAsync()
         => await _context.SaveChangesAsync();

        public Task SoftDeleteAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
