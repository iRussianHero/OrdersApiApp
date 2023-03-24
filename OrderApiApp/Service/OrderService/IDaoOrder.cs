using OrderApiApp.Model.Entity;

namespace OrderApiApp.Service.OrderService
{
    public interface IDaoOrder
    {
        Task<List<Order>> GetAllAsync();
        Task<Order> AddAsync(Order order);
        Task<Order> UpdateAsync(Order order);
        Task<Order> DeleteAsync(Order order);
        Task<Order> GetAsync(Order order);
    }
}
