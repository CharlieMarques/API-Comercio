using API_Comercio.Models.Domain;

namespace API_Comercio.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategory(int categoryId);
        Task AddCategory(Category category);
        Task SaveChange();
    }
}
