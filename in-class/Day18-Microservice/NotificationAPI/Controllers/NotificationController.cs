using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotificationAPI.MessagingService;

namespace NotificationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        QueueService queue;

        public NotificationController(IConfiguration config)
        {
            queue = new QueueService(config);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var msg = await queue.ReadMsgAsync("orderqueue");

            return Ok(msg);
        }
    }
}
