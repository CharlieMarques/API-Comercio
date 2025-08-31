using API_Comercio.Models.DTOs;
using API_Comercio.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_Comercio.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>>GetCategories()
        {
            var categories = await _categoryService.GetAllCategories();
            return Ok(categories);
        }
        [HttpGet("{categoryId}")]
        public async Task<ActionResult<CategoryDTO>>GetCategory(int categoryId)
        {
            var category = await _categoryService.GetCategoryById(categoryId);
            if(category == null)
                return NotFound();
            return Ok(category);
        }
        [HttpPost]
        public async Task<ActionResult>CreateCategory(CategoryDTO categoryDTO)
        {
            await _categoryService.AddCategory(categoryDTO);
            return CreatedAtAction(nameof(GetCategory), new { categoryId = categoryDTO.Id }, categoryDTO);
        }
    }
}
