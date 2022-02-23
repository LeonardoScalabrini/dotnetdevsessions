using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext Context;

        public ProductRepository(ApplicationDbContext context)
        {
            Context = context;
        }        

        public async Task<Product> CreateAsync(Product entity)
        {
            Context.Add(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await Task.FromResult(Context.Products.ToList());
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await Context.Products.FindAsync(id);
        }

        public async Task<Product> RemoveAsync(Product entity)
        {
            Context.Remove(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<Product> UpdateAsync(Product entity)
        {
            Context.Update(entity);
            await Context.SaveChangesAsync();
            return entity;
        }
    }
}
