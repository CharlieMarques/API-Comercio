using API_Comercio.Data;
using API_Comercio.Models.Domain;
using API_Comercio.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_Comercio.Repositories
{
    public class BrandRepositoty : IBrandRepository
    {
        
        private readonly AppDbContext _context;
        public BrandRepositoty(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddBrand(Brand brand)
        {
            try
            {
                await _context.Brands.AddAsync(brand);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Brand>> GetAllBrand()
        {
            try
            {
                return await _context.Brands.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Brand> GetBrand(int brandId)
        {
            try
            {
                return await _context.Brands.FirstOrDefaultAsync(p => p.Id == brandId);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public async Task SaveChange()
        {
           await _context.SaveChangesAsync();
        }
    }
}
