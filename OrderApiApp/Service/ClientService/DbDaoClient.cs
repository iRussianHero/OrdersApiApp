using Microsoft.EntityFrameworkCore;
using OrderApiApp.Model;
using OrderApiApp.Model.Entity;

namespace OrderApiApp.Service.ClientService
{
    public class DbDaoClient : IDaoClient
    {
        private static List<Client> _clients = new List<Client>();
        private static int currentId = 1;
        private ApplicationDbContext db;

        public DbDaoClient(ApplicationDbContext db) {
            this.db = db;
        }

        public async Task<Client> AddAsync(Client client)
        {
            await db.AddAsync(client);
            await db.SaveChangesAsync();
            return client;
        }

        public Task<Client> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Client>> GetAllAsync()
        {
            return db.Client.ToListAsync();
        }

        public Task<Client> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Client> UpdateAsync(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
