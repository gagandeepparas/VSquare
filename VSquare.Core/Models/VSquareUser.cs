using Microsoft.AspNetCore.Identity;

namespace VSquare.Core.Models
{
    public class VSquareUser : IdentityUser
    {
        public string Address { get; set; }
    }
}
