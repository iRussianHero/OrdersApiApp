using Microsoft.EntityFrameworkCore;
using OrderApiApp.Model;
using OrderApiApp.Model.Entity;

namespace OrderApiApp.Service.OrderService
{
    public class DbDaoOrder : IDaoOrder
    {
        private static List<Order> _orders = new List<Order>();
        private static int currentId = 1;
        private ApplicationDbContext db;

        public DbDaoOrder(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<Order> AddAsync(Order order)
        {
            await db.AddAsync(order);
            await db.SaveChangesAsync();
            return order;
        }

        public async Task<Order> DeleteAsync(Order order)
        {
            db.Order.Remove(order);
            await db.SaveChangesAsync();
            return order;
        }

        public Task<List<Order>> GetAllAsync()
        {
            return db.Order.ToListAsync();
        }

        public async Task<Order> GetAsync(Order order)
        {
            return await db.Order.FirstOrDefaultAsync(p => p.Id == order.Id);
        }

        public async Task<Order> UpdateAsync(Order order)
        {
            db.Order.Update(order);
            await db.SaveChangesAsync();
            return order;
        }
    }
}
