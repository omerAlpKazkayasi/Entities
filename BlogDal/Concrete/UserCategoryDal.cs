using BlogDal.Abstract;
using Entities.Concrete;
using Entities.DbContext;

namespace BlogDal.Concrete
{
    public class UserCategoryDal : BaseDal<UserCategory>, IUserCategoryDal
    {
        public UserCategoryDal(BlogDbContext context) : base(context)
        {
        }
    }
}
