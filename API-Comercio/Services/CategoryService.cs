using API_Comercio.Models.Domain;
using API_Comercio.Models.DTOs;
using API_Comercio.Repositories.Interfaces;
using API_Comercio.Services.Interfaces;

namespace API_Comercio.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task AddCategory(CategoryDTO categoryDTO)
        {
            var category = new Category
            {
                Name = categoryDTO.Name
            };
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategories()
        {
            var categories = await _categoryRepository.GetAllCategories();
            return categories.Select(p => new CategoryDTO
            {
                Id = p.Id,
                Name = p.Name
            });
        }

        public async Task<CategoryDTO> GetCategoryById(int categoryId)
        {
            var category = await _categoryRepository.GetCategory(categoryId);
            if (category == null)
                return null;
            return new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name
            };
        }
    }
}
