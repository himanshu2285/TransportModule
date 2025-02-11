using Microsoft.AspNetCore.Identity;

namespace TransportModule1.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
        
    }
}
