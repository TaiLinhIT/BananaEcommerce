using BananaEcommerceApp.Models;
using Microsoft.EntityFrameworkCore;

public class BananaDbcontext : DbContext
{
    public BananaDbcontext(DbContextOptions<BananaDbcontext> options) : base(options)
    {
    }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Promotion> Promotions { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Custommer> Customers { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Category> Categories { get; set; }
}