using Core.Entities;
using Core.Models.Request;
using Core.Models.Response;
using Core.RepositoryContracts;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository c)
        {
            _categoryRepository = c;
        }

        public int DeleteCategory(int id)
        {
            return _categoryRepository.Delete(id);
        }

        public IEnumerable<CategoryResponseModel> GetAllCategories()
        {
            List<CategoryResponseModel> list = new List<CategoryResponseModel>();

            var collection = _categoryRepository.GetAll();
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

        public CategoryResponseModel GetCategoryById(int id)
        {
            var category = _categoryRepository.GetById(id);
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

        public int InserCategory(CategoryRequestModel category)
        {
            Category c = new Category()
            {
                Id = category.Id,
                Name = category.Name
            };

            return _categoryRepository.Insert(c);
        }

        public int UpdateCategory(CategoryRequestModel category)
        {
            Category c = new Category()
            {
                Id = category.Id,
                Name = category.Name
            };

            return _categoryRepository.Update(c);
        }
    }
}
