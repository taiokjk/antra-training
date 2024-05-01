using Core.Entities;
using Core.Models.Request;
using Core.Models.Response;

namespace Core.Interfaces.Services
{
    public interface IShipperService : IBaseService<Shipper, ShipperRequestModel, ShipperResponseModel>
    {
    }
}
