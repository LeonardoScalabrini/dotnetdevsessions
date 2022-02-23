using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces
{
    public interface ICrudRepository<T> where T : Entity
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T?> GetByIdAsync(int id);

        Task<T> CreateAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<T> RemoveAsync(T entity);
    }
}
