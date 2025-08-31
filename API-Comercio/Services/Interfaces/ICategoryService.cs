using API_Comercio.Models.Domain;
using API_Comercio.Models.DTOs;

namespace API_Comercio.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetAllCategories();
        Task<CategoryDTO> GetCategoryById(int categoryId);
        Task AddCategory(CategoryDTO categoryDTO);
    }
}
