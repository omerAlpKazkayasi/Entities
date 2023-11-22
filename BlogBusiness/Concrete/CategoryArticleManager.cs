using BlogDal.Abstract;

namespace BlogBusiness.Concrete
{
    public class CategoryArticleManager
    {
        private readonly ICategoryArticleDal _categoryArticledal;

        public CategoryArticleManager(ICategoryArticleDal catergoryarticledal)
        {
            _categoryArticledal = catergoryarticledal;
        }
    }
}
