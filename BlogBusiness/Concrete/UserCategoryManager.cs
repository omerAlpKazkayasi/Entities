using BlogDal.Abstract;

namespace BlogBusiness.Concrete
{
    public class UserCategoryManager
    {
        private readonly IUserCategoryDal _userCategorydal;

        public UserCategoryManager(IUserCategoryDal userCategorydal)
        {
            _userCategorydal = userCategorydal;
        }
    }
}
