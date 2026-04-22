using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;

namespace ProductAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> Products =
    [
        new Product { Id = 1, Name = "Keyboard", Price = 1200, Category = "Electronics" },
        new Product { Id = 2, Name = "Notebook", Price = 80, Category = "Stationery" }
    ];

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAllProducts()
    {
        return Ok(Products);
    }

    [HttpGet("{id}")]
    public ActionResult<Product> GetProductById(int id)
    {
        var product = Products.FirstOrDefault(item => item.Id == id);

        if (product == null)
        {
            return NotFound(new { message = "Product not found." });
        }

        return Ok(product);
    }

    [HttpPost]
    public ActionResult<Product> AddProduct(Product product)
    {
        product.Id = Products.Count == 0 ? 1 : Products.Max(item => item.Id) + 1;
        Products.Add(product);

        return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, Product updatedProduct)
    {
        var product = Products.FirstOrDefault(item => item.Id == id);

        if (product == null)
        {
            return NotFound(new { message = "Product not found." });
        }

        product.Name = updatedProduct.Name;
        product.Price = updatedProduct.Price;
        product.Category = updatedProduct.Category;

        return Ok(product);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var product = Products.FirstOrDefault(item => item.Id == id);

        if (product == null)
        {
            return NotFound(new { message = "Product not found." });
        }

        Products.Remove(product);

        return Ok(new { message = "Product deleted successfully." });
    }
}
