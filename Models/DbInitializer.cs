using System.Linq;

namespace StoreFront.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if(!context.Products.Any())
            {
                context.AddRange(
                    new Product { Name = "Contact Lens", Price = 36.00M, ShortDescription = "Put in your eyes to help you see better", LongDescription = "This is the long description for contact lenses.  I refuse to spend too much time mocking this out because I already know it won't be used for very long.", ThumbnailUrl = "/images/contactlens.jpg" },
                    new Product { Name = "Petit Ecolier Cookies", Price = 4.50M, ShortDescription = "Put in your mouth to taste something good.", LongDescription = "This is the long description for cookies.  I refuse to spend too much time mocking this out because I already know it won't be used for very long.", ThumbnailUrl = "/images/cookies.jpeg" },
                    new Product { Name = "Computer Monitor", Price = 340.00M, ShortDescription = "Buy several to make yourself seem important", LongDescription = "This is the long description for the computer monitor.  I refuse to spend too much time mocking this out because I already know it won't be used for very long.", ThumbnailUrl = "/images/monitor.jpg" },
                    new Product { Name = "Car", Price = 55000.00M, ShortDescription = "Sit in it and go places", LongDescription = "This is the long description for a car.  I refuse to spend too much time mocking this out because I already know it won't be used for very long.", ThumbnailUrl = "/images/car.jpg" },
                    new Product { Name = "Headphones", Price = 300.00M, ShortDescription = "Put them over your ears to hear things that aren't happening around you.", LongDescription = "This is the long description for some headphones.  I refuse to spend too much time mocking this out because I already know it won't be used for very long.", ThumbnailUrl = "/images/headphones.jpg" }
                );
            }

            context.SaveChanges();
        }
    }
}
