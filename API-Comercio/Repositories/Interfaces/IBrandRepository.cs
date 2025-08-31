using API_Comercio.Models.Domain;

namespace API_Comercio.Repositories.Interfaces
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetAllBrand();
        Task<Brand> GetBrand(int brandId);
        Task AddBrand(Brand brand);
        Task SaveChange();
    }
}
