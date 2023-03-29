using Microsoft.EntityFrameworkCore;
using OrderApiApp.Model;
using OrderApiApp.Model.Entity;

namespace OrderApiApp.Service.ReceiptService
{
    public class DbDaoReceipt : IDaoReceipt
    {
        private ApplicationDbContext db;

        public DbDaoReceipt(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<Receipt> AddAsync(Receipt receipt)
        {
            await db.AddAsync(receipt);
            await db.SaveChangesAsync();
            return receipt;
        }

        public async Task<Receipt> DeleteAsync(Receipt receipt)
        {
            if (await db.Receipt.FirstOrDefaultAsync() != null)
            {
                db.Receipt.Remove(receipt);
                await db.SaveChangesAsync();
            }
            return receipt;
        }

        public Task<List<Receipt>> GetAllAsync()
        {
            return db.Receipt.ToListAsync();
        }

        public async Task<Receipt> GetAsync(Receipt receipt)
        {
            return await db.Receipt.FirstOrDefaultAsync(p => p.Id == receipt.Id);
        }

        public async Task<Receipt> UpdateAsync(Receipt receipt)
        {
            if (await db.Receipt.FirstOrDefaultAsync() != null)
            {
                db.Receipt.Update(receipt);
                await db.SaveChangesAsync();
            }
            return receipt;
        }

        public Task<List<Receipt>> GetOrderAsync(int orderId)
        {
            //return await db.Receipt.ToListAsync();
            List<Receipt> list = db.Receipt.ToList();
            List<Receipt> resualt = new List<Receipt>();

            foreach (Receipt receipt in list)
            {
                if (receipt.OrderId == orderId)
                {
                    resualt.Add(receipt);
                }
            }

            return Task.FromResult(resualt);
            //return resualt;
        }

        public async Task<Double> GetTotalSumAsync(int orderId)
        {
            List<Receipt> receipts = await GetOrderAsync(orderId);
            double total = 0;
            db.Product.Load();

            foreach (Receipt receipt in receipts)
            {
                total += receipt.Quantity * receipt.Product.Cost;
            }

            return total;
        }
    }
}
