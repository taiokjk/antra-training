using Core.Entities;
using Core.Interfaces.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class RegionRepository : BaseRepository<Region>,
                                    IRegionRepository
    {
        public RegionRepository(EShopDbContext context) : base(context)
        {
        }
    }
}
