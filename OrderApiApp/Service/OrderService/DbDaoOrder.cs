using OrderApiApp.Model.Entity;

namespace OrderApiApp.Service.OrderService
{
    public class DbDaoOrder : IDaoOrder
    {
        public Task<Order> AddAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<Order> DeleteAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateAsync(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
