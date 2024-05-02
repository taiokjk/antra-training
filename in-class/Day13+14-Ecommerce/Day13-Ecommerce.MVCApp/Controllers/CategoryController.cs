using Core.Models.Request;
using Core.Models.Response;
using Core.RepositoryContracts;
using Microsoft.AspNetCore.Mvc;

namespace Day13_Ecommerce.MVCApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        
        public CategoryController(ICategoryService c)
        {
            _categoryService = c;
        }

        public IActionResult Index()
        {
            var collection = _categoryService.GetAllCategories();

            return View(collection);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryRequestModel category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.InserCategory(category);

                return RedirectToAction("Index");
            }

            return View(category);
        }

        public IActionResult Delete(int id)
        {
            var item = _categoryService.GetCategoryById(id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(CategoryResponseModel category)
        {
            var item = _categoryService.DeleteCategory(category.Id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _categoryService.GetCategoryById(id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(CategoryResponseModel category)
        {
            if (ModelState.IsValid)
            {
                CategoryRequestModel c = new CategoryRequestModel()
                {
                    Id = category.Id,
                    Name = category.Name
                };

                _categoryService.UpdateCategory(c);

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
