using Core.Entities;
using Core.Models.Request;
using Core.Models.Response;
using Core.RepositoryContracts;

namespace Infrastructure.Service
{
    public class CategoryServiceAsync : ICategoryServiceAsync
    {
        private readonly ICategoryRepositoryAsync _categoryRepository;

        public CategoryServiceAsync(ICategoryRepositoryAsync c)
        {
            _categoryRepository = c;
        }

        public async Task<int> DeleteCategoryAsync(int id)
        {
            return await _categoryRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CategoryResponseModel>> GetAllCategoriesAsync()
        {
            List<CategoryResponseModel> list = new List<CategoryResponseModel>();

            var collection = await _categoryRepository.GetAllAsync();
            if (collection != null)
            {
                foreach (var item in collection)
                {
                    CategoryResponseModel m = new CategoryResponseModel()
                    {
                        Id = item.Id,
                        Name = item.Name
                    };

                    list.Add(m);
                }
            }

            return list;
        }

        public async Task<CategoryResponseModel> GetCategoryByIdAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category != null)
            {
                CategoryResponseModel categoryResponseModel = new CategoryResponseModel()
                {
                    Id = category.Id,
                    Name = category.Name
                };

                return categoryResponseModel;
            }

            return null;
        }

        public Task<int> InserCategoryAsync(CategoryRequestModel category)
        {
            Category c = new Category()
            {
                Name = category.Name
            };

            return _categoryRepository.InsertAsync(c);
        }

        public Task<int> UpdateCategoryAsync(CategoryRequestModel category, int id)
        {
            Category c = new Category()
            {
                Id = id,
                Name = category.Name
            };

            return _categoryRepository.UpdateAsync(c);
        }
    }
}
