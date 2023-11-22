using Entities.Concrete;

namespace BlogBusiness.Abstract
{
    public interface IUserCategoryService
    {
        Task<UserCategory> GetUserCategoryObjectAsync(int id);

        
        Task<List<UserCategory>> GetAllAsync();

        Task CreateUserCategoryAsync(UserCategory model);

        Task UpdateUserCategoryAsync(UserCategory model);

        Task DeleteUserCategoryAsync(int id);
    }
    
}
