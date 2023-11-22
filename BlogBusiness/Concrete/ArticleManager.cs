using BlogBusiness.Abstract;
using BlogDal.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBusiness.Concrete
{
    public class ArticleManager:IArticleService
    {
        private readonly IArticleDal _articledal;

        public ArticleManager(IArticleDal articledal)
        {
            _articledal = articledal;
        }

        public async Task CreateArticleAsync(Article model)
        {
          await _articledal.AddAsync(model);    
        }

        public async Task DeleteArticleAsync(int id)
        {
            await _articledal.DeleteAsync(await _articledal.GetByIdAsync(id));
        }

        public async Task<Article> GetArticleObjectAsync(int id)
        {
           return  await _articledal.GetByIdAsync(id);
        }

        public async Task<Article> GetArticleWithCategoryAsync(int id)
        {
           
            return await _articledal.GetAsync(x => x.ID== id, x => x.ArticleCategories);
        }

        public async Task UpdateArticleAsync(Article model)
        {
             await _articledal.UpdateAsync(model);
        }
    }
}
