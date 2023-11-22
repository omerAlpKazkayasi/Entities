using Microsoft.AspNetCore.Identity;
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
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public List<UserCategory> Users { get; set; }
        public List<CategoryArticle> ArticleCategories { get; set; }
    }
    
    public class UserCategory:BaseEntity
    {
        public int CategoryID { get; set;}
        public Category Category { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
    public class AppUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? UserUrl { get; set; }
        public List<UserCategory> UserCategory { get; set; }
        public List<Article> Article { get; set; }

    }
}
