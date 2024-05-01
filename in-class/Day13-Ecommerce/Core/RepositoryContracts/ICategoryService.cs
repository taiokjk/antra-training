using Core.Models.Request;
using Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepositoryContracts
{
    public interface ICategoryService
    {
        IEnumerable<CategoryResponseModel> GetAllCategories();
        CategoryResponseModel GetCategoryById(int id);
        int InserCategory(CategoryRequestModel category);
        int UpdateCategory(CategoryRequestModel category);
        int DeleteCategory(int id);
    }
}
