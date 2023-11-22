using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBusiness.Abstract
{
    public interface IArticleService
    {
        Task<Article> GetArticleObjectAsync(int id);
        
        Task<Article> GetArticleWithCategoryAsync(int id);

        Task CreateArticleAsync(Article model);

        Task UpdateArticleAsync(Article model);
        
        Task DeleteArticleAsync(int id);
    }
    
}
