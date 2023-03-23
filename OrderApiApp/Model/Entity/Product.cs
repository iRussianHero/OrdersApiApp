namespace OrderApiApp.Model.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Article { get; set; }
        public double Cost { get; set; }


        public List<Receipt> Receipt { get; set; }


        public Product()
        {
            Id = default;
            Name = "";
            Article = 0;
            Cost = 0;
        }
    }
}
