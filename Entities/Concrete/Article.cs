using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Article:BaseEntity
    {
        public List<CategoryArticle> ArticleCategories { get; set; }
        public string Title { get; set; }        
        public string Content { get; set; }
        public int ReadingTime { get; set; }
        public int ReadingCount { get; set; }
        public AppUser User { get; set; }
        public string UserId { get; set; }

    }
}
