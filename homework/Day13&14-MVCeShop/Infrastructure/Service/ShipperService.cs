using AutoMapper;
using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models.Request;
using Core.Models.Response;

namespace Infrastructure.Service
{
    public class ShipperService : BaseService<Shipper, ShipperRequestModel, ShipperResponseModel, IShipperRepository>,
                                    IShipperService
    {
        public ShipperService(IShipperRepository r, IMapper m) : base(r, m)
        {
        }
    }
}
