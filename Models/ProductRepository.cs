using System.Collections.Generic;
using System.Linq;

namespace StoreFront.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return this.appDbContext.Products;
        }

        public Product GetProductById(int productId)
        {
            return this.appDbContext.Products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
