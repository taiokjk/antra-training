using Core.Models.Request;
using Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepositoryContracts
{
    public interface IProductService
    {
        IEnumerable<ProductResponseModel> GetAllProducts();
        ProductResponseModel GetProductById(int id);
        int InsertProduct(ProductRequestModel product);
        int UpdateProduct(ProductRequestModel product);
        int DeleteProduct(int id);
    }
}
