using Entities.Concrete;

namespace BlogBusiness.Abstract
{
    public interface ICategoryService
    {
        Task<Category> GetCategoryObjectAsync(int id);

        Task<List<Category>> GetAllAsync();

        Task CreateCategoryAsync(Category model);

        Task UpdateCategoryAsync(Category model);

        Task DeleteCategoryAsync(int id);
    }
    
}
