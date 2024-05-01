using Core.RepositoryContracts;
using Microsoft.AspNetCore.Mvc;

namespace Day13_Ecommerce.MVCApp.Components
{
    public class ProductComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductComponent(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_productService.GetAllProducts());
        }
    }
}
