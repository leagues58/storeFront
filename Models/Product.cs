namespace StoreFront.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsInStock { get; set; }
    }
}
