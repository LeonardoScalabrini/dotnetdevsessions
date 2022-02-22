using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces
{
    internal interface IRepository<T> where T : Entity
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetByIdAsync(int id);

        Task<IEnumerable<T>> CreateAsync(T entity);

        Task<IEnumerable<T>> UpdateAsync(T entity);

        Task<IEnumerable<T>> RemoveAsync(T entity);
    }
}
