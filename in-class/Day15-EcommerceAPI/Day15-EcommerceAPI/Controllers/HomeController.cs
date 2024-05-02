using Microsoft.AspNetCore.Mvc;

namespace Day15_EcommerceAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hi");
        }

        [HttpGet("{i:int:max(100)}")]
        public IActionResult Get(int i)
        {
            if (i > 0)
                return Ok("Number greater than 0");
            return BadRequest("Number less than 0");
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            return Ok(product);
        }

        // Variable in the Query String
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Record with id = {id}");
        }

        // Variable in the parameter
        [HttpDelete]
        public IActionResult Delete(string id)
        {
            return Ok($"Record with id = {id}");
        }

        [HttpGet]
        [Route("search")]
        public IActionResult GetBySearch(int id, string name, string? department)
        {
            return Ok($"id = {id}, name = {name}, department = {department}");
        }
    }
}
