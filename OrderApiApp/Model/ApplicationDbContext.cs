using Microsoft.EntityFrameworkCore;
using OrderApiApp.Model.Entity;

namespace OrderApiApp.Model
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Client { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
