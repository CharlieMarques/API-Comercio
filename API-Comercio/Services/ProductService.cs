using API_Comercio.Models.Domain;
using API_Comercio.Models.DTOs;
using API_Comercio.Repositories.Interfaces;
using API_Comercio.Services.Interfaces;

namespace API_Comercio.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public async Task AddProduct(ProductCreateUpdateDTO productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                CategoryId = productDto.CategoryId,
                BrandId = productDto.BrandId
            };
            await _productRepository.AddProduct(product);
            await _productRepository.SaveChange();
        }
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductReadDTO>> GetAllProduct()
        {
            var products = await _productRepository.GetAllProducts();
            return products.Select(p => new ProductReadDTO
            {
                Id = p.Id,
                Name = p.Name,
                ProductCode = p.ProductCode,
                Brand = p.Brand.Name,
                Categories = p.ListCategory.Select(c => c.Name).ToList()
            });
        }

        public async Task<ProductReadDTO> GetProductById(int productId)
        {
            var product = await _productRepository.GetProduct(productId);
            if (product == null)
                return null;
            return new ProductReadDTO
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Categories = product.ListCategory.Select(c  => c.Name).ToList(),
                Brand = product.Brand.Name,
                ProductCode = product.ProductCode,
                MinimumStock = product.MinimumStock,
                CurrentStock = product.CurrentStock
            };
        }
    }
}
