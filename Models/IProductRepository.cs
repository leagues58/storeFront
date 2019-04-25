using System.Collections.Generic;

namespace StoreFront.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int productId);
    }
}
