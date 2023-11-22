namespace Entities.Concrete
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public List<UserCategory> Users { get; set; }
        public List<CategoryArticle> ArticleCategories { get; set; }
    }
}
