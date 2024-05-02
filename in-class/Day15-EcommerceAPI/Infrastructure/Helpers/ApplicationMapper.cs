using AutoMapper;
using Core.Entities;
using Core.Models.Request;
using Core.Models.Response;

namespace Infrastructure.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<ProductRequestModel, Product>().ReverseMap();
            CreateMap<ProductResponseModel, Product>().ReverseMap();
            CreateMap<ProductRequestModel, ProductResponseModel>().ReverseMap();

            CreateMap<CategoryRequestModel, Category>().ReverseMap();
            CreateMap<CategoryResponseModel, Category>().ReverseMap();
            CreateMap<CategoryRequestModel, CategoryResponseModel>().ReverseMap();
        }
    }
}
