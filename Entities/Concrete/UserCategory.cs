namespace Entities.Concrete
{
    public class UserCategory:BaseEntity
    {
        public int CategoryID { get; set;}
        public Category Category { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}
