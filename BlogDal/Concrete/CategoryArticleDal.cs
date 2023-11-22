using BlogDal.Abstract;
using Entities.Concrete;
using Entities.DbContext;

namespace BlogDal.Concrete
{
    public class CategoryArticleDal : BaseDal<CategoryArticle>, ICategoryArticleDal
    {
        public CategoryArticleDal(BlogDbContext context) : base(context)
        {
        }
    }
}
