using OrderApiApp.Model.Entity;

namespace OrderApiApp.Service.ReceiptService
{
    public interface IDaoReceipt
    {
        Task<List<Receipt>> GetAllAsync();
        Task<Receipt> AddAsync(Receipt receipt);
        Task<Receipt> UpdateAsync(Receipt receipt);
        Task<Receipt> DeleteAsync(Receipt receipt);
        Task<Receipt> GetAsync(Receipt receipt);
    }
}
