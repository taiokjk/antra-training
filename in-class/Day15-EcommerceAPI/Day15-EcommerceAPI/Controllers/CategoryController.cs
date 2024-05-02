using Core.Models.Request;
using Core.RepositoryContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day15_EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServiceAsync _categoryService;

        public CategoryController(ICategoryServiceAsync c)
        {
            _categoryService = c;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();

            return Ok(categories);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CategoryRequestModel category)
        {
            return Ok(await _categoryService.InserCategoryAsync(category));
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update(CategoryRequestModel category, int id)
        {
            return Ok(await _categoryService.UpdateCategoryAsync(category, id));
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _categoryService.DeleteCategoryAsync(id));
        }
    }
}
