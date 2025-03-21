namespace BananaEcommerceApp.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public Custommer Custommer { get; set; }
        public Product product { get; set; }
    }
}