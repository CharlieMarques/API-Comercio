using API_Comercio.Data;
using API_Comercio.Models.Domain;
using API_Comercio.Repositories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace API_Comercio.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddProduct(Product product)
        {           
            try
            {
                await _context.Products.AddAsync(product);               
            }
            catch (Exception)
            {
                throw;
            }
            
            
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            try
            {
                return await _context.Products
                    .Include(p => p.Brand)
                    .Include(p => p.ListCategory).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Product> GetProduct(int productId)
        {
            try
            { 
                    return await _context.Products
                    .Include(p => p.Brand)
                    .Include(p => p.ListCategory)
                    .FirstOrDefaultAsync(p => p.Id == productId);
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
