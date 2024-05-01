using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
        {
            
        }

        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}
