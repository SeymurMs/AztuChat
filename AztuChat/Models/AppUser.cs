using Microsoft.AspNetCore.Identity;

namespace AztuChat.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
    }
}
