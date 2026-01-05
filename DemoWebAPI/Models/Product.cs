namespace DemoWebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
