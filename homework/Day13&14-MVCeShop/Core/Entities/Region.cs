using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Region
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Shipper> Shippers { get; set; } = new List<Shipper>();
    }
}