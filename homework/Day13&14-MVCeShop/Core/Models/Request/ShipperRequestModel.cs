﻿using Core.Entities;

namespace Core.Models.Request
{
    public class ShipperRequestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Phone { get; set; }
        public string Contact_Person { get; set; }
        public virtual ICollection<Region> Regions { get; set; } = new List<Region>();
    }
}
