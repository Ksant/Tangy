namespace Tangy_Models.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Active { get; set; }
        public double Price { get; set; }
    }
}