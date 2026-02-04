using Microsoft.AspNetCore.Identity;

namespace AmazonShop.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string AvatarUrl { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
