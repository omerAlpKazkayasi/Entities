using Microsoft.AspNetCore.Identity;

namespace Entities.Concrete
{
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
