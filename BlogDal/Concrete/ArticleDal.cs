using BlogDal.Abstract;
using Entities.Concrete;
using Entities.DbContext;

namespace BlogDal.Concrete
{
    public class ArticleDal : BaseDal<Article>, IArticleDal
    {
        public ArticleDal(BlogDbContext context) : base(context)
        {
        }
    }
}
