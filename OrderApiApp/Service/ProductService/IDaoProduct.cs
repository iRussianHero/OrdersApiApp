using OrderApiApp.Model.Entity;

namespace OrderApiApp.Service.ProductService
{
    public interface IDaoProduct
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> AddAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<Product> DeleteAsync(Product product);
        Task<Product> GetAsync(Product product);
    }
}
