namespace BananaEcommerceApp.Models;
public class Custommer{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Country { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    // public string Token { get; set; }
    // public string RefreshToken { get; set; }
    // public DateTime? TokenExpires { get; set; }
    // public DateTime? RefreshTokenExpires { get; set; }
    public List<Order> Orders { get; set; }
}