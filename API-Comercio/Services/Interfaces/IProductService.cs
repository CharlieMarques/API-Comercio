using API_Comercio.Models.DTOs;

namespace API_Comercio.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductReadDTO>> GetAllProduct();
        Task<ProductReadDTO> GetProductById(int productId);
        Task AddProduct(ProductCreateUpdateDTO productDto);
             
    }
}
