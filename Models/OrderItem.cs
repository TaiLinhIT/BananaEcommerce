namespace BananaEcommerceApp.Models;
public class OrderItem{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public Product Product { get; set; }
    public Order Order { get; set; }
}