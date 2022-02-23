using CleanArch.Application.Interfaces;
using CleanArch.Domain.Entities;

namespace CleanArch.Application
{
    public class CategoryService : ICategoryService
    {
        public async Task<Category> Add(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public async Task<Category> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}