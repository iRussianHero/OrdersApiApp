using Microsoft.EntityFrameworkCore;
using OrderApiApp.Model;
using OrderApiApp.Model.Entity;

namespace OrderApiApp.Service.ProductService
{
    public class DbDaoProduct : IDaoProduct
    {
        private ApplicationDbContext db;

        public DbDaoProduct(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<Product> AddAsync(Product product)
        {
            await db.AddAsync(product);
            await db.SaveChangesAsync();
            return product;
        }

        public async Task<Product> DeleteAsync(Product product)
        {
            if (await db.Product.FirstOrDefaultAsync() != null)
            {
                db.Product.Remove(product);
                await db.SaveChangesAsync();
            }
            return product;
        }

        public Task<List<Product>> GetAllAsync()
        {
            return db.Product.ToListAsync();
        }

        public async Task<Product> GetAsync(Product product)
        {
            return await db.Product.FirstOrDefaultAsync(p => p.Id == product.Id);
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            if (await db.Product.FirstOrDefaultAsync() != null)
            {
                db.Product.Update(product);
                await db.SaveChangesAsync();
            }
            return product;
        }
    }
}
