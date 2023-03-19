namespace OrderApiApp.Model.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Client()
        {
            Id = default;
            Name = "";
        }
    }
}
