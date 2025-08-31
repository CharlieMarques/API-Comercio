using API_Comercio.Data;
using API_Comercio.Models.Domain;
using API_Comercio.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_Comercio.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context; 
        }
        public async Task AddCategory(Category category)
        {
            try
            {
                await _context.Categories.AddAsync(category);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            try
            {
                return await _context.Categories.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Category> GetCategory(int categoryId)
        {
            try
            {
                return await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
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
