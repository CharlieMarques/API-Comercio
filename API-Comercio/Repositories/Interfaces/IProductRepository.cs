using API_Comercio.Models.Domain;

namespace API_Comercio.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProduct(int productId);
        Task AddProduct(Product product);
        Task SaveChange();
    }
}
