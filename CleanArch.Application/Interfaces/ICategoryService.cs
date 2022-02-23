using CleanArch.Domain.Entities;

namespace CleanArch.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategories();

        Task<Category> GetById(int id);

        Task<Category> Add(Category category);

        Task<Category> Update(Category category);

        Task<Category> Remove(int id);
    }
}
