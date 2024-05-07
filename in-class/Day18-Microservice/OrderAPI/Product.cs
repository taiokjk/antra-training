namespace OrderAPI
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public int VendorId { get; set; }
        public string Color { get; set; }
    }
}
