using MagicVillaAPI.Data;
using MagicVillaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVillaAPI.Repository
{
    public class VillaRepository : IVillaRepository<Villa>
    {
        readonly private ApplicationDBContext _dbContext;
        public VillaRepository(ApplicationDBContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Villa>> GetAllAsync(Expression<Func<Villa, bool>>? filter = null) 
        {
           IQueryable<Villa> query = _dbContext.Villas;
           if(filter != null) query = query.Where(filter);
           return await query.ToListAsync();
        }
        public async Task<Villa?> GetAsync(Expression<Func<Villa, bool>>? filter = null, bool isTracked = true) 
        {
            IQueryable<Villa> query = isTracked ? _dbContext.Villas : _dbContext.Villas.AsNoTracking();
            if (filter != null) query = query.Where(filter);
            return await query.FirstOrDefaultAsync();
        }
        public async Task<int> CreateAsync(Villa entity) 
        {
           await _dbContext.Villas.AddAsync(entity);
           return await SaveAsync();
        }
        public async Task<int> UpdateAsync(Villa entity) 
        {
            _dbContext.Update(entity);
            return await SaveAsync();
        }
        public async Task<int> RemoveAsync(Villa entity) 
        {
            _dbContext.Remove(entity);
            return await SaveAsync();
        }
       public async Task<int> SaveAsync() 
       {
         return await _dbContext.SaveChangesAsync(); 
       }
    }
}
