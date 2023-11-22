using BlogDal.Abstract;

namespace BlogBusiness.Concrete
{
    public class CategoryManager
    {
        private readonly ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }
    }
}
