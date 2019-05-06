using System.Collections.Generic;
using System.Linq;

namespace StoreFront.Models
{
    public class MockProductRepository : IProductRepository
    {
        private List<Product> products;

        public MockProductRepository()
        {
            if (products == null)
            {
                InitializeProducts();
            }
        }

        private void InitializeProducts()
        {
            products = new List<Product>
            {
                new Product {Id = 1, Name = "Contact Lens", Price = 36.00M, ShortDescription = "Put in your eyes to help you see better", LongDescription = "This is the long description for contact lenses.  I refuse to spend too much time mocking this out because I already know it won't be used for very long.", ThumbnailUrl = "/images/contactlens.jpg"},
                new Product {Id = 2, Name = "Petit Ecolier Cookies", Price = 4.50M, ShortDescription = "Put in your mouth to taste something good.", LongDescription = "This is the long description for cookies.  I refuse to spend too much time mocking this out because I already know it won't be used for very long.", ThumbnailUrl = "/images/cookies.jpeg"},
                new Product {Id = 3, Name = "Computer Monitor", Price = 340.00M, ShortDescription = "Buy several to make yourself seem important", LongDescription = "This is the long description for the computer monitor.  I refuse to spend too much time mocking this out because I already know it won't be used for very long.", ThumbnailUrl = "/images/monitor.jpg"},
                new Product {Id = 4, Name = "Car", Price = 55000.00M, ShortDescription = "Sit in it and go places", LongDescription = "This is the long description for a car.  I refuse to spend too much time mocking this out because I already know it won't be used for very long.", ThumbnailUrl = "/images/car.jpg"},
                new Product {Id = 5, Name = "Headphones", Price = 300.00M, ShortDescription = "Put them over your ears to hear things that aren't happening around you.", LongDescription = "This is the long description for some headphones.  I refuse to spend too much time mocking this out because I already know it won't be used for very long.", ThumbnailUrl = "/images/headphones.jpg"},
                new Product {Id = 5, Name = "Ice Cream", Price = 5.15M, ShortDescription = "Delicious cold.", LongDescription = "This is the long description for some icecream.  I refuse to spend too much time mocking this out because I already know it won't be used for very long.", ThumbnailUrl = "/images/icecream.jpg"}
            };
        }


        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(p => p.Id == productId);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
    }
}
