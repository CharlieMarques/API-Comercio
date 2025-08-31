using API_Comercio.Models.DTOs;

namespace API_Comercio.Services.Interfaces
{
    public interface IBrandService
    {
        Task<IEnumerable<BrandDTO>> GetAllBrands();
        Task<BrandDTO> GetBrandById(int brandId);
        Task AddBrand(BrandDTO brandDto);
    }
}
