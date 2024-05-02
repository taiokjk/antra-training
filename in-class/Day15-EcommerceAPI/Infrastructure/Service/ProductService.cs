using AutoMapper;
using Core.Entities;
using Core.Models.Request;
using Core.Models.Response;
using Core.RepositoryContracts;

namespace Infrastructure.Service
{
    public class ProductServiceAsync : IProductServiceAsync
    {
        private readonly IProductRepositoryAsync _productRepository;
        private readonly IMapper _mapper;

        public ProductServiceAsync(IProductRepositoryAsync productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;

        }

        public Task<int> DeleteProductAsync(int id)
        {
            return _productRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductResponseModel>> GetAllProductsAsync()
        {
            var collection = await _productRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<ProductResponseModel>>(collection);
        }

        public async Task<ProductResponseModel> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product != null)
            {
                return _mapper.Map<ProductResponseModel>(product);
            }

            return null;
        }

        public Task<int> InsertProductAsync(ProductRequestModel product)
        {
            var entity = _mapper.Map<Product>(product);
            return _productRepository.InsertAsync(entity);
        }

        public Task<int> UpdateProductAsync(ProductRequestModel product, int id)
        {
            var entity = _mapper.Map<Product>(product);
            entity.Id = id;
            return _productRepository.UpdateAsync(entity);
        }
    }
}
