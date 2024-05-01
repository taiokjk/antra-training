using Core.Entities;
using Core.Interfaces.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class ShipperRepository : BaseRepository<Shipper>,
                                    IShipperRepository
    {
        public ShipperRepository(EShopDbContext context) : base(context)
        {
        }
    }
}
