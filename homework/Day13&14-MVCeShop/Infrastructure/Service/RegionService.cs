using AutoMapper;
using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models.Request;
using Core.Models.Response;

namespace Infrastructure.Service
{
    public class RegionService : BaseService<Region, RegionRequestModel, RegionResponseModel, IRegionRepository>,
                                IRegionService
    {
        public RegionService(IRegionRepository r, IMapper m) : base(r, m)
        {
        }
    }
}
