using BananaEcommerceApp.Models;
using BananaEcommerceApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BananaEcommerceApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly ProductService _productService;
    public ProductController(ProductService productService)
    {
        _productService = productService;
    }
    

    [HttpGet]
    public ActionResult<List<Product>> GetAll()
    {
        var products =  _productService.GetProducts(); 
        
        return Ok(products);
    }

    [HttpGet("{id}")]
    public ActionResult<Product> GetById(int id)
    {
        var product = _productService.GetProductById(id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }
    [HttpPost]
    public ActionResult<Product> Create(Product product)
    {
        _productService.AddProduct(product);
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Product product)
    {
        if (id != product.Id)
        {
            return BadRequest();
        }
        try
        {
            _productService.UpdateProduct(product);
        }
        catch (DbUpdateConcurrencyException)
        {
            if (_productService.GetProductById(id) == null)
            {
                return NotFound();
            }
            throw;
        }
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = _productService.GetProductById(id);
        if (product == null)
        {
            return NotFound();
        }
        _productService.DeleteProduct(id);
        return NoContent();
    }
}
