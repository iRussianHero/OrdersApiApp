using OrderApiApp.Model.Entity;

namespace OrderApiApp.Service.ClientService
{
    public interface IDaoClient
    {
        Task<List<Client>> GetAllAsync();
        Task<Client> AddAsync(Client client);
        Task<Client> UpdateAsync(Client client);
        Task<Client> DeleteAsync(int id);
        Task<Client> GetAsync(int id);
    }
}
