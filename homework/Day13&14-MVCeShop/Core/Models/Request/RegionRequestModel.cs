using Core.Entities;

namespace Core.Models.Request
{
    public class RegionRequestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Shipper> Shippers { get; set; } = new List<Shipper>();
    }
}
