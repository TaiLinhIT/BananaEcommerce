using BananaEcommerceApp.Models;
using Microsoft.EntityFrameworkCore;


namespace BananaEcommerceApp.Services;

public  class ProductService
{
    private readonly BananaDbcontext _context;
    public ProductService(BananaDbcontext bananaDbcontext)
    {
        _context = bananaDbcontext;
    }

    public List<Product> GetProducts()
    {
        return _context.Products.ToList();
    }

    public Product GetProductById(int id)
    {
        return _context.Products.Find(id);
    }
    public void AddProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }
    public void UpdateProduct(Product product)
    {
        _context.Entry(product).State = EntityState.Modified;
        _context.SaveChanges();
    }
    public void DeleteProduct(int id)
    {
        var product = _context.Products.Find(id);
        _context.Products.Remove(product);
        _context.SaveChanges();
    }
    
}