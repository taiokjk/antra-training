using Microsoft.AspNetCore.Mvc;
using OrderAPI.MessageQueue;
using SharedMessageService;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private QueueService queue;
        public OrderController(IConfiguration configuration)
        {
            queue = new QueueService(configuration);
        }

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

        [HttpPost]
        public async Task<IActionResult> Post(OrderDetail od)
        {
            await queue.SendMessageAsync<OrderDetail>(od, "orderqueue");

            return Ok("Message has been sent");
        }
    }    
}
