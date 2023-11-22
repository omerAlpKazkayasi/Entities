using BlogDal.Abstract;
using Entities.Concrete;
using Entities.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDal.Concrete
{
    public class CategoryDal : BaseDal<Category>, ICategoryDal
    {
        public CategoryDal(BlogDbContext context) : base(context)
        {
        }
    }
}
