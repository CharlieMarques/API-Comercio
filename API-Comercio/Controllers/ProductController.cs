using API_Comercio.Models.DTOs;
using API_Comercio.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_Comercio.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductReadDTO>>> GetProducts()
        {
            var products = await _service.GetAllProduct();
            return Ok(products);
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<ProductReadDTO>> GetProduct(int Id)
        {
            var product = await _service.GetProductById(Id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
        [HttpPost]
        public async Task<ActionResult> CreateProduct(ProductCreateUpdateDTO productDto)
        {
            await _service.AddProduct(productDto);
            return CreatedAtAction(nameof(GetProduct), new { Id = productDto.Id }, productDto);
        }


    }
}

