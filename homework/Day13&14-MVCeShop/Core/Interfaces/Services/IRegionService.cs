using Core.Entities;
using Core.Models.Request;
using Core.Models.Response;

namespace Core.Interfaces.Services
{
    public interface IRegionService : IBaseService<Region, RegionRequestModel, RegionResponseModel>
    {
    }
}
