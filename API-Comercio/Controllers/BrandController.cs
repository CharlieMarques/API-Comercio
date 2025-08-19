using API_Comercio.Models;
using API_Comercio.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_Comercio.Controllers
{
    [ApiController]
    [Route("API/[controller]")]
    public class BrandController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Brand>> GetBrands()
        {
            return Ok(BrandDataStore.Current.Brands);
        }
        [HttpGet("{brandId}")]
        public ActionResult<Brand>GetBrand(int brandId)
        {
            var brand = BrandDataStore.Current.Brands.FirstOrDefault(b => b.Id == brandId);
            if (brand == null)
                return NotFound();
            return Ok(brand);
        }
    }
}
