namespace OrderApiApp.Model.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Article { get; set; }
        public double Cost { get; set; }


        public List<Receipt> Receipt { get; set; }


    }
}
