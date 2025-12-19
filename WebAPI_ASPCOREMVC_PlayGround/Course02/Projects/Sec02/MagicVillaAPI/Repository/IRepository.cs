using System.Linq.Expressions;

namespace MagicVillaAPI.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);
        Task<T?> GetAsync(Expression<Func<T, bool>>? filter = null, bool isTracked = false);
        Task<int> CreateAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> RemoveAsync(T entity);
        Task<int> SaveAsync();
    }
}
