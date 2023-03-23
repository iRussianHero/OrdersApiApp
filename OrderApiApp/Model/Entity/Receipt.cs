namespace OrderApiApp.Model.Entity
{
    public class Receipt
    {
        public int Id { get; set; }
        public int Quantity { get; set; }


        public int OrderId { get; set; }
        public Order Order { get; set; }


        public int ProductId { get; set; }
        public Product Product { get; set; }


        public Receipt()
        {
            Id = default;
            Quantity = 0;
            OrderId = default;
            ProductId = default;
        }
    }
}
