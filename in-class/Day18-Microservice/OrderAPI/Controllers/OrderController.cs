using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public async Task<IActionResult> Get()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://host.docker.internal:43156/");
            HttpResponseMessage msg = await client.GetAsync("api/product/getallproducts");

            if (msg != null && msg.IsSuccessStatusCode)
            {
                var result = await msg.Content.ReadFromJsonAsync<List<Product>>();

                return Ok(result);
            }

            return BadRequest();
        }
    }
}
