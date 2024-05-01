using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class RegionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
