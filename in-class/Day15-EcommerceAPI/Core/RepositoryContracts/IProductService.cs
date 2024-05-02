using Core.Models.Request;
using Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepositoryContracts
{
    public interface IProductServiceAsync
    {
        Task<IEnumerable<ProductResponseModel>> GetAllProductsAsync();
        Task<ProductResponseModel> GetProductByIdAsync(int id);
        Task<int> InsertProductAsync(ProductRequestModel product);
        Task<int> UpdateProductAsync(ProductRequestModel product, int id);
        Task<int> DeleteProductAsync(int id);
    }
}
