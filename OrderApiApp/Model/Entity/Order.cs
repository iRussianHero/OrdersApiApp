using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace OrderApiApp.Model.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }


        public List<Receipt> Receipt { get; set; }


        public int ClientId { get; set; }
        public Client Client { get; set; }


        public Order()
        {
            Id = default;
            Description = "";
            ClientId = default;
        }
    }
}
