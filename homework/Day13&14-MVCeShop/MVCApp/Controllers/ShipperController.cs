using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class ShipperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
