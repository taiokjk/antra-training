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
            CreateMap<RegionRequestModel, Region>().ReverseMap();
            CreateMap<RegionResponseModel, Region>().ReverseMap();
            CreateMap<RegionRequestModel, RegionResponseModel>().ReverseMap();

            CreateMap<ShipperRequestModel, Shipper>().ReverseMap();
            CreateMap<ShipperResponseModel, Shipper>().ReverseMap();
            CreateMap<ShipperRequestModel, ShipperResponseModel>().ReverseMap();
        }
    }
}
