namespace Entities.Concrete
{
    public class CategoryArticle:BaseEntity
    {
        public Article Article   { get; set; }
        public int   ArticleID     { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}