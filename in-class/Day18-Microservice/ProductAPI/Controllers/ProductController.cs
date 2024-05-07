using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        List<Product> products = new List<Product>();
        public ProductController()
        {
            products.Add(new Product { Id = 1, Color = "Blue", Description = "asdasd", Name = "Chair", Price = 40.32m, Status = true, VendorId = 1 });
            products.Add(new Product { Id = 2, Color = "Black", Description = "gfsdgsd", Name = "Table", Price = 100.75m, Status = true, VendorId = 1 });
            products.Add(new Product { Id = 3, Color = "Green", Description = "gvdfv", Name = "Door", Price = 80m, Status = true, VendorId = 2 });
            products.Add(new Product { Id = 4, Color = "Yellow", Description = "ewrw", Name = "Frame", Price = 10.5m, Status = true, VendorId = 2 });
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            
            var t = Task.FromResult(products);

            return Ok(t);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var t = Task.FromResult(products.Where(x => x.Id == id).FirstOrDefault());

            return Ok(t);
        }
    }
}
