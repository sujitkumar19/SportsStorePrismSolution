using System.Collections.Generic;
using System.Threading.Tasks;
using SportsstorePrism.Infrastucture.Entities;

namespace SportsstorePrism.Infrastucture.Abstract
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();
        Task<List<Product>> GetProductsByCategoryAsync(string categoryName);
        Task<Product> GetProductAsync(int productId);
        Task<Product> AddProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task DeleteProductAsync(int productId);
    }
}
