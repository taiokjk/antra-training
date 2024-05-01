using Core.Models.Request;
using Core.RepositoryContracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day13_Ecommerce.MVCApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService,
                                ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var categories = _categoryService.GetAllCategories().Select(
                x => new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                });
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductRequestModel product)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Inside");
                _productService.InsertProduct(product);
                return RedirectToAction("Index");
            }

            Console.WriteLine("Outside");
            var categories = _categoryService.GetAllCategories().Select(
                x => new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                });
            return View(product);
        }
    }
}
