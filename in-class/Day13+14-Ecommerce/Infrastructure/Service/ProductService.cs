using AutoMapper;
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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;

        }

        public int DeleteProduct(int id)
        {
            return _productRepository.Delete(id);
        }

        public IEnumerable<ProductResponseModel> GetAllProducts()
        {
            var collection = _productRepository.GetAll();

            return _mapper.Map<IEnumerable<ProductResponseModel>>(collection);
        }

        public ProductResponseModel GetProductById(int id)
        {
            var product = _productRepository.GetById(id);
            if (product != null)
            {
                return _mapper.Map<ProductResponseModel>(product);
            }

            return null;
        }

        public int InsertProduct(ProductRequestModel product)
        {
            var entity = _mapper.Map<Product>(product);
            return _productRepository.Insert(entity);
        }

        public int UpdateProduct(ProductRequestModel product)
        {
            var entity = _mapper.Map<Product>(product);
            return _productRepository.Update(entity);
        }
    }
}
