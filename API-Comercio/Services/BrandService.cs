using API_Comercio.Models.Domain;
using API_Comercio.Models.DTOs;
using API_Comercio.Repositories.Interfaces;
using API_Comercio.Services.Interfaces;

namespace API_Comercio.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService( IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public async Task AddBrand(BrandDTO brandDto)
        {
            var brand = new Brand
            {               
                Name = brandDto.Name
            };
            await _brandRepository.AddBrand(brand);
            await _brandRepository.SaveChange();
        }

        public async Task<IEnumerable<BrandDTO>> GetAllBrands()
        {
            var brands = await _brandRepository.GetAllBrand();
            return brands.Select(p => new BrandDTO
            {
                Id = p.Id,
                Name = p.Name
            });
        }

        public async Task<BrandDTO> GetBrandById(int brandId)
        {
            var brand = await _brandRepository.GetBrand(brandId);
            if(brand == null)
                return null;
            return new BrandDTO
            {
                Id = brand.Id,
                Name = brand.Name
            };
        }
    }
}
