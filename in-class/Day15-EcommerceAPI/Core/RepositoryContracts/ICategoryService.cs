using Core.Models.Request;
using Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepositoryContracts
{
    public interface ICategoryServiceAsync
    {
        Task<IEnumerable<CategoryResponseModel>> GetAllCategoriesAsync();
        Task<CategoryResponseModel> GetCategoryByIdAsync(int id);
        Task<int> InserCategoryAsync(CategoryRequestModel category);
        Task<int> UpdateCategoryAsync(CategoryRequestModel category, int id);
        Task<int> DeleteCategoryAsync(int id);
    }
}
