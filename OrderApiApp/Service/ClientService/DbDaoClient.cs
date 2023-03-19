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

        public async Task<Client> DeleteAsync(Client client)
        {
            db.Client.Remove(client);
            await db.SaveChangesAsync();
            return client;
        }

        public Task<List<Client>> GetAllAsync()
        {
            return db.Client.ToListAsync();
        }

        public async Task<Client> GetAsync(Client client)
        {
            List<Client> allClients = new List<Client>();
            allClients = await db.Client.ToListAsync();
            foreach (Client thisClient in allClients)
            {
                if (client.Id == thisClient.Id) return thisClient;
            }
            return null;
        }

        public async Task<Client> UpdateAsync(Client client)
        {
            db.Client.Update(client);
            await db.SaveChangesAsync();
            return client;
        }
    }
}
