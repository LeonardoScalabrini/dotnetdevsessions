using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext Context;

        public CategoryRepository(ApplicationDbContext context)
        {
            Context = context;
        }        

        public async Task<Category> CreateAsync(Category entity)
        {
            Context.Add(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await Task.FromResult(Context.Categories.ToList());
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            return await Context.Categories.FindAsync(id);
        }

        public async Task<Category> RemoveAsync(Category entity)
        {
            Context.Remove(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<Category> UpdateAsync(Category entity)
        {
            Context.Update(entity);
            await Context.SaveChangesAsync();
            return entity;
        }
    }
}
