using Entities.Concrete;

namespace BlogBusiness.Abstract
{
    public interface ICategoryArticleArticleService
    {
        Task<CategoryArticle> GetCategoryArticleObjectAsync(int id);

        Task<List<CategoryArticle>> GetAllAsync();

        Task CreateCategoryArticleAsync(CategoryArticle model);

        Task UpdateCategoryArticleAsync(CategoryArticle model);

        Task DeleteCategoryArticleAsync(int id);
    }
    
}
