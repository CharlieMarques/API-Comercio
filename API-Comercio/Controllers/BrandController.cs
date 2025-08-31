using API_Comercio.Models.Domain;
using API_Comercio.Models.DTOs;
using API_Comercio.Services;
using API_Comercio.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_Comercio.Controllers
{
    [ApiController]
    [Route("API/[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet]
        public async Task <ActionResult<IEnumerable<Brand>>> GetBrands()
        {
            var brands = await _brandService.GetAllBrands();
            return Ok(brands);
        }
        [HttpGet("{brandId}")]
        public async Task<ActionResult<BrandDTO>>GetBrand(int brandId)
        {
            var brand = await _brandService.GetBrandById(brandId);
            if (brand == null)
                return NotFound();
            return Ok(brand);
        }
        public async Task<ActionResult>CreateBrand(BrandDTO brandDTO)
        {
            await _brandService.AddBrand(brandDTO);
            return CreatedAtAction(nameof(GetBrand), new { brandId = brandDTO.Id }, brandDTO);
        }
    }
}
